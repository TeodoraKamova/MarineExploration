using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Obj : MonoBehaviour {

	public ObjectSpawner spawner;
	public GameObject game_area;

    public float speed;

	void Start () {
       
	}
	
	void Update () {
        Move();
	}

    void Move()
    {
       
        transform.position += transform.up * (Time.deltaTime * speed);


        float distance = Vector3.Distance(transform.position, game_area.transform.position);
        if (distance > spawner.death_circle_radius)
        {
            RemoveObj();
        }
    }

    void RemoveObj()
    {

        Destroy(gameObject);
        spawner.obj_count -= 1;
    }

  
}
