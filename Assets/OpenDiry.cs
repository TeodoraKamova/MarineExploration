using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenDiry : MonoBehaviour {

	// Use this for initialization
	void OnMouseDown()
    {
        SceneManager.LoadScene("Diary");
    }
}
