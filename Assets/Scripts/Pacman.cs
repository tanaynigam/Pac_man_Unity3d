using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pacman : MonoBehaviour {

    [SerializeField]
    Transform pac_man;

    [SerializeField]
    Transform Blinky;

    [SerializeField]
    Transform Pinky;

    [SerializeField]
    Transform Inky;

    [SerializeField]
    Transform Clyde;

    


    public float moveSpeed;
    private float input1;
    private float input2;
    private float t = Time.deltaTime;
    bool shouldmove = true;
    public static float score;

    public static float life = 3;
    private float dist_b;
    private float dist_p;
    private float dist_i;
    private float dist_c;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        TextMesh score_display = GameObject.Find("Score").GetComponent<TextMesh>();
        score_display.text = "Score\n" + score;

        TextMesh lives_display = GameObject.Find("Lives").GetComponent<TextMesh>();
        lives_display.text = "Lives\n" + life;

        input1 = Input.GetAxis("Horizontal");
        input2 = Input.GetAxis("Vertical");
        // pac_man.Translate(0, 0, input2 * t * moveSpeed);

      if(input1 != 0 || input2 != 0)
        {
            shouldmove = true;
        }

      if(shouldmove == true)
        {
            pac_man.Translate(input1 * t * moveSpeed, 0 , 0);
            pac_man.Translate(0, 0, input2 * t * moveSpeed);
            pac_man.eulerAngles = new Vector3(0, 0, 0);

        }

        dist_b = Vector3.Distance(pac_man.position, Blinky.position);
        dist_p = Vector3.Distance(pac_man.position, Pinky.position);
        dist_i = Vector3.Distance(pac_man.position, Inky.position);
        dist_c = Vector3.Distance(pac_man.position, Clyde.position);

        if (dist_b<0.5 || dist_p<0.5 || dist_i<0.5 || dist_c < 0.5)
        {
            if (life == 1)
            {
                SceneManager.LoadScene("Pacman");
                life = 3;
                score = 0;
            }
            else
            {
                life = life - 1;
                pac_man.position = new Vector3(0, 0.5f, -7.75f);
                Blinky.position = new Vector3(0.75f, 0.5f, 1f);
                Pinky.position = new Vector3(2.25f, 0.5f, 1f);
                Inky.position = new Vector3(-0.75f, 0.5f, 1f);
                Clyde.position = new Vector3(-2.25f, 0.5f, 1);
            }
        }

    }

   /* private void OnTriggerEnter(Collider other)
    {
        pac_man.Translate(new Vector3(0, 0, 0));
        shouldmove = false;
    }*/
}
