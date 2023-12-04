using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LabyrinttiLuojaScript : MonoBehaviour
{
    [SerializeField]
    private LabyrinttiSolu _LabyrinttiSoluPrefab;

    [SerializeField]
    private int _labyrinttiLeveys;

    [SerializeField]
    private int _labyrinttiSyvyys;

    private LabyrinttiSolu[,] _labyrinttiRuudukko;

    // Start is called before the first frame update
    void Start()
    {
        /*
         * Tämä tässä luo ison laatikon soluja tai siis niin leveän ja syvän massan kuin untitysta laitetaan. Tästä massasta sitten louhitaan labyrintti.
         */

        _labyrinttiRuudukko = new LabyrinttiSolu[_labyrinttiLeveys, _labyrinttiSyvyys];

        for (int x = 0; x < _labyrinttiLeveys; x++)
        {
            for(int z = 0; z < _labyrinttiSyvyys; z ++)
            {
                //Ohjelma eteni väärässä järjestykesssä ja antoi siksi NullReference Exceptionin
                _labyrinttiRuudukko[x, z] = Instantiate(_LabyrinttiSoluPrefab, new Vector3(x, 0, z), Quaternion.identity);
                //Instantiate(_LabyrinttiSoluPrefab, new Vector3(x, 0, z), Quaternion.identity);
            }
        }

        LuoLabyrintti(null, _labyrinttiRuudukko[0,0]);
    }

    private void LuoLabyrintti(LabyrinttiSolu edellinenSolu, LabyrinttiSolu nykyinenSolu)
    {
        nykyinenSolu.Vieraile();

        PyyhiSeinat(edellinenSolu, nykyinenSolu);

        
        
        LabyrinttiSolu seuraavaSolu;
        do
        {
            seuraavaSolu = HaeSeuraavaVierailematonSolu(nykyinenSolu);



            if (seuraavaSolu != null)
            {
                LuoLabyrintti(nykyinenSolu, seuraavaSolu);
            }

        } while (seuraavaSolu != null);
    }

    private LabyrinttiSolu HaeSeuraavaVierailematonSolu(LabyrinttiSolu nykyinenSolu)
    {
        var vierailemattomatSolut = HaeVierailemattomatSolut(nykyinenSolu);

        return vierailemattomatSolut.OrderBy(_ => Random.Range(1, 10)).FirstOrDefault();
    }

    private IEnumerable<LabyrinttiSolu> HaeVierailemattomatSolut(LabyrinttiSolu nykyinenSolu)
    {
        int x = (int)nykyinenSolu.transform.position.x;
        int z = (int)nykyinenSolu.transform.position.z;

        if (x + 1 < _labyrinttiLeveys)
        {
            var soluOikealla = _labyrinttiRuudukko[x + 1, z];

            if (soluOikealla.OnkoVierailtu == false)
            {
                yield return soluOikealla;
            }
        }

        if (x - 1 >= 0)
        {
            var soluVasemmalla = _labyrinttiRuudukko[x - 1, z];

            if (soluVasemmalla.OnkoVierailtu == false)
            {
                yield return soluVasemmalla;
            }
        }

        if (z + 1 < _labyrinttiSyvyys)
        {
            var soluEdessa = _labyrinttiRuudukko[x, z +1];

            if(soluEdessa.OnkoVierailtu == false)
            { 
                yield return soluEdessa; 
            }
        }

        if(z -1 >= 0)
        {
            var soluTakana = _labyrinttiRuudukko[x, z -1];
            
            if(soluTakana.OnkoVierailtu == false)
            { 
                yield return soluTakana; 
            }
        }
    }
    //Pyyhkii seinät
    private void PyyhiSeinat(LabyrinttiSolu edellinenSolu, LabyrinttiSolu nykyinenSolu)
    {
        if (edellinenSolu == null)
        {
            return;
        }

        if (edellinenSolu.transform.position.x < nykyinenSolu.transform.position.x)
        {
            edellinenSolu.PyyhiOikeaSeina();
            nykyinenSolu.PyyhiVasenSeina();
            return;
        }

        if (edellinenSolu.transform.position.x > nykyinenSolu.transform.position.x)
        {
            edellinenSolu.PyyhiVasenSeina();
            nykyinenSolu.PyyhiOikeaSeina();
            return;
        }

        if (edellinenSolu.transform.position.z < nykyinenSolu.transform.position.z)
        {
            edellinenSolu.PyyhiEtuSeina();
            nykyinenSolu.PyyhiTakaSeina();
            return;
        }

        if (edellinenSolu.transform.position.z > nykyinenSolu.transform.position.z)
        {
            edellinenSolu.PyyhiTakaSeina();
            nykyinenSolu.PyyhiEtuSeina();
            return;
        }
    }

    //Asettaa pelin aluksi pelihahmon aloitusruutun.
    public void InstantiatePelaaja(GameObject playerCharacterPrefab)
    {
        Instantiate(playerCharacterPrefab, _labyrinttiRuudukko[0, 0].transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
