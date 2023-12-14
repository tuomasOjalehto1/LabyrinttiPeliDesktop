
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using UnityEngine;

//public class PatrolState : BaseState
//{
//    public int waypointIndex;
//    public override void Enter()
//    {
//        waypointIndex =0;
//    }

//    public override void Perform()
//    {
//        PatrolCycle();
//        Debug.Log("Performing patol state");
//    }
//    public override void Exit()
//    {

//    }

//    public void PatrolCycle()
//    {
//        //if(vihollinen.Agent.remainingDistance < 0.2f)
//        //{
//        //    if(waypointIndex < vihollinen.polku.waypoints.Count -1) 
//        //    {
//        //        waypointIndex++;
//        //    }
//        //    else
//        //    {
//        //        waypointIndex = 0;
//        //        //vihollinen.Agent.SetDestination(vihollinen.polku.waypoints[waypointIndex].position);
//        //        vihollinen.Agent.SetDestination(vihollinen.polku.waypoints.Any() ? vihollinen.polku.waypoints[waypointIndex].position : vihollinen.transform.position);
//        //    }
//        //}

//        if (vihollinen.Agent.remainingDistance < 0.2f)
//        {
//            if (waypointIndex < vihollinen.polku.waypoints.Count - 1)
//            {
//                waypointIndex++;
//            }
//            else
//            {
//                waypointIndex = 0;
//            }

//            SetDestinationToWaypoint();
//        }
//    }

//    private void SetDestinationToWaypoint()
//    {
//        // Set the destination to the current waypoint
//        vihollinen.Agent.SetDestination(
//            vihollinen.polku.waypoints.Any()
//                ? vihollinen.polku.waypoints[waypointIndex].position
//                : vihollinen.transform.position
//        );
//    }

//}
