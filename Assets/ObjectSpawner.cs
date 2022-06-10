using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {
  
    public GameObject game_area;
    public GameObject obj_spr;

    public int obj_count = 0;
    public int obj_limit = 20;
    public int obj_per_frame = 1;

    public float spawn_circle_radius = 15.0f;
    public float death_circle_radius = 20.0f;

    public float fastest_speed = 7.0f;
    public float slowest_speed = 0.75f;
	void Start () {
       
	}
	
	void Update () {
		 MaintainPopulation();
    }

    void MaintainPopulation()
    {
        if (obj_count < obj_limit)
        {
            for (int i = 0; i < obj_per_frame; i++)
            {
                Vector3 position = GetRandomPosition();
                SCR_Obj obj_script = AddObj(position);
                obj_script.transform.Rotate(Vector3.forward * Random.Range(-45.0f, 45.0f));
            }
        }
    }

    Vector3 GetRandomPosition()
    {

        Vector3 position = Random.insideUnitCircle.normalized;

        position *= spawn_circle_radius;
        position += game_area.transform.position;

        return position;
    }

    SCR_Obj AddObj(Vector3 position)
    {

        obj_count += 1;
        GameObject new_obj = Instantiate(
            obj_spr,
            position,
            Quaternion.FromToRotation(Vector3.up, (game_area.transform.position - position)),
            gameObject.transform
        );

        SCR_Obj obj_script = new_obj.GetComponent<SCR_Obj>();
        obj_script.spawner = this;
        obj_script.game_area = game_area;
        obj_script.speed = Random.Range(slowest_speed, fastest_speed);

        return obj_script;
    }

}
