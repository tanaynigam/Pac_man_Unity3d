using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubes : MonoBehaviour {

    [SerializeField]
    Transform pac_man;

    [SerializeField]
    Transform cube;

    private float dist;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        dist = Vector3.Distance(cube.position, pac_man.position);
        cube.Rotate(Vector3.right * Time.deltaTime * 50);

        if (dist < 0.5)
        {
            Destroy(cube.gameObject);
            Pacman.score += 10;
        }

    }

}
