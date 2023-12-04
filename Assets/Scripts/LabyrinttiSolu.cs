using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabyrinttiSolu : MonoBehaviour
{
    /*
     * Objekti muuttujat seinille ja funktiot seinien poistamiselle kartalta.
    */
    [SerializeField]
    private GameObject _vasenSeina;

    [SerializeField]
    private GameObject _oikeaSeina;

    [SerializeField]
    private GameObject _etuSeina;

    [SerializeField]
    private GameObject _takaSeina;

    [SerializeField]
    private GameObject _vierailematonSeina;

    public bool OnkoVierailtu { get; private set; }


    public void Vieraile()
    {
        OnkoVierailtu = true;
        _vierailematonSeina.SetActive(false);
    }

    public void PyyhiVasenSeina()
    {
        _vasenSeina.SetActive(false);
    }

    public void PyyhiOikeaSeina()
    {
        _oikeaSeina.SetActive(false);
    }

    public void PyyhiEtuSeina()
    {
        _etuSeina.SetActive(false);
    }

    public void PyyhiTakaSeina()
    {
        _takaSeina.SetActive(false);
    }
}
