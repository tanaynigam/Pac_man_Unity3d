using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour {

    [SerializeField]
    Transform pac_man;

    [SerializeField]
    Transform power_up;

    public static bool powerup = false;
    private float dist;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        dist = Vector3.Distance(power_up.position, pac_man.position);
        power_up.Rotate(Vector3.right * Time.deltaTime * 50);

        if (dist < 1)
        {
            Destroy(power_up.gameObject);
            Pacman.score += 50;
            StartCoroutine(Countdown());
            //powerup = false;
            // StopAllCoroutines();


        }
    }

    IEnumerator Countdown()
    {
        //Create a Countdown wait timer
        //Call End game if failed
        powerup = true;

        yield return new WaitForSeconds(5);

        powerup = false;

        
    }

}
