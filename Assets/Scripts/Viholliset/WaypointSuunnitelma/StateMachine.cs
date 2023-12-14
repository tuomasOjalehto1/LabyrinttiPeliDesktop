//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class StateMachine : MonoBehaviour
//{
//    public BaseState activeState;
//    public PatrolState patrolState;
//    //partiointi tilan property 

//    public void Initialise()
//    {
//        patrolState = new PatrolState();
//        ChangeState(patrolState);
//    }

//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if(activeState != null)
//        {
//            activeState.Perform();
//        }
//    }

//    //Katsotaan mik‰ tila p‰‰ll‰
//    public void ChangeState(BaseState newState)
//    {
//        //Jos on mik‰‰n niin siivotaan ja resetoidaan
//        if(activeState != null) 
//        { 
//            activeState.Exit();
//        }
//        //Vaihdeteaan uuteen tilaan

//        activeState = newState;

//        if(activeState != null )
//        {
//            //Laitetaan uusi tila
//            activeState.stateMachine = this;
//            activeState.vihollinen = GetComponent<Vihollinen>();
            
//            activeState.Enter();
//        }
//    }
//}
