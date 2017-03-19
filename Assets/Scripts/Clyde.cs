using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Clyde : MonoBehaviour
{

    [SerializeField]
    Transform pac_man;

    [SerializeField]
    Transform clyde;

    private float x = Random.Range(-15, 15);
    private float z = Random.Range(-15, 15);
    private float dist;
    private float dist2;

    void Start()
    {
        StartCoroutine(Countdown());

    }

    // Update is called once per frame
    void Update()
    {

        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        //dist = dist = Vector3.Distance(pac_man.position, clyde.position);
        dist = Vector3.Distance(clyde.position, new Vector3(x, 0, z));
        if (dist < 2)
        {
            x = Random.Range(-13, 13);
            z = Random.Range(-13, 13);

        }
        else
        {
            agent.destination = new Vector3(x, 0, z);
            clyde.eulerAngles = new Vector3(0, 0, 0);
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
