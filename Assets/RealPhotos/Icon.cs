using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "New icon", menuName="Diary/icon")]
public class Icon : ScriptableObject {

	new public string name;
	public Sprite img;

	public void Redirect()
    {
		Debug.Log(name);
    }

}

