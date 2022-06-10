using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class SolvedPuzzles : MonoBehaviour
{
    [HideInInspector]
    public static Dictionary<string, bool> solved;
    // Tries to add new TK every time when firstscene is entered => error
    void Start() {
        if (solved != null) return;

        solved = new Dictionary<string, bool>();
        for (int i = 0; i < transform.childCount; i++)
        {
            solved.Add(transform.GetChild(i).name.Replace("Spawner",""), false);
            //Debug.Log(transform.GetChild(i).name.Replace("Spawner", ""));
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
