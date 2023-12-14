//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.AI;

//public class Vihollinen : MonoBehaviour
//{
//    private StateMachine stateMachine;
//    private NavMeshAgent agent;
//    public NavMeshAgent Agent { get => agent; }
//    [SerializeField]
//    private string currentState;
//   // public Polku polku;
//    private GameObject player;
//    public float nakoEtaisyys;
//    //Näkökentän asteluku
//    public float fieldOfView =95;
//    // Start is called before the first frame update
//    void Start()
//    {
//        stateMachine = GetComponent<StateMachine>();
//        agent = GetComponent<NavMeshAgent>();
//        //kutsutaan oletustila
//        stateMachine.Initialise();
//        player = GameObject.FindGameObjectWithTag("Player");
//        //Pitäisi mahdollistaa viholisten liikkua toistensa läpi
//        Physics.IgnoreLayerCollision(7, 7, true);
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        CanSeePlayer();
//    }

//    public bool CanSeePlayer()
//    {
//        if(player != null)
//        {
//            //Onko tarpeeksi lähellä että näkee pelaajan
//            if(Vector3.Distance(transform.position, player.transform.position)< nakoEtaisyys)
//            {
//                Vector3 targetDirection = player.transform.position - transform.position;
//                float angleToPlayer = Vector3.Angle(targetDirection, transform.forward);
//                if(angleToPlayer >= -fieldOfView && angleToPlayer <= fieldOfView)
//                {
//                    Ray ray = new Ray(transform.position, targetDirection);
//                    RaycastHit hitInfo = new RaycastHit();
//                    if(Physics.Raycast(ray,out hitInfo, nakoEtaisyys))
//                    {
//                        if(hitInfo.transform.gameObject == player)
//                        {
//                            return true;
//                        }
//                    }
//                    Debug.DrawRay(ray.origin, ray.direction * nakoEtaisyys);
//                }
//            }
//        }
//        return false;
//    }
//}
