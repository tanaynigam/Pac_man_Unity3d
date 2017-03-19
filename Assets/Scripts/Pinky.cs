using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pinky : MonoBehaviour {


    [SerializeField]
    Transform pac_man;

    [SerializeField]
    Transform pinky;

    [SerializeField]
    Transform Blinky;

    public float moveSpeed;
    private float input1;
    private float input2;
    private float t = Time.deltaTime;
    private float dist;

    // Use this for initialization
    void Start () {
        StartCoroutine(Countdown());
    }
	
	// Update is called once per frame
	void Update () {
        dist = Vector3.Distance(pac_man.position, pinky.position);
        if (dist>7)
        {
        input1 = Input.GetAxis("Horizontal");
        input2 = Input.GetAxis("Vertical");
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
            agent.destination = pac_man.position + new Vector3(input1 * 7, 0, input2 * 7);
        pinky.eulerAngles = new Vector3(0, 0, 0);
        }
        else
        {
            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            agent.destination = pac_man.position;
        }
    }

    IEnumerator Countdown()
    {
        //Create a Countdown wait timer
        //Call End game if failed
        yield return new WaitForSeconds(5f);
        //yield return null; //remove this line of code
    }
}
