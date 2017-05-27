using UnityEngine;
using System.Collections;

public class ekorre_rörelse : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame

    float timeleft = Random.Range(2f, 3f);

    float direction = Random.Range(1, 3);

    float speed = Random.Range(-0.1f, 0.1f);
    void Update () {

        

       
        Vector3 Position = transform.position;
       

        timeleft -= Time.deltaTime;

        if (direction == 1)
        {
            Position.x += speed;
            transform.position = Position;
        }
        if (direction == 2)
        {
            Position.y += speed;
            transform.position = Position;
        }
        if (timeleft < 0)
        {
           timeleft = Random.Range(5f, 10f);
            direction = Random.Range(1, 3);
            speed = Random.Range(-0.1f, 0.1f);

            

        }

      

       
	}
}
//Timer
//Random