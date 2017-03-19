using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Blinky : MonoBehaviour {

    [SerializeField]
    Transform pac_man;

    [SerializeField]
    Transform blinky;

    void Start () {
        StartCoroutine(Countdown());
                
    }
	
	// Update is called once per frame
	void Update () {

        NavMeshAgent agent = GetComponent<NavMeshAgent>();

        if (Powerup.powerup == false)
        {
            //agent.speed = 5;
            //agent.acceleration = 10000;
            agent.destination = pac_man.position;
            blinky.eulerAngles = new Vector3(0, 0, 0);
        }
        else if(Powerup.powerup == true)
        {
            agent.destination = new Vector3(0.75f, 0.5f, 1f);
        }

    }

//    void powerup()
//    {

//    }
    IEnumerator Countdown()
    {
        //Create a Countdown wait timer
        //Call End game if failed
        yield return new WaitForSeconds(5f);
        //yield return null; //remove this line of code
    }

}
