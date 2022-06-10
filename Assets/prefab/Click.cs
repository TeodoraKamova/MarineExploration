using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour {
	public string sceneName;
	public string DiaryPage;

    public bool found = false;

   /* void ChangeFound(bool found)
    {
        for (int i = 0; i < transform.parent.childCount; i++)
        {
            GameObject sibling = transform.parent.GetChild(i).gameObject;
            sibling.GetComponent<Click>().found = found;
        }
    }*/
    bool GetDicValue()
    {
        return SolvedPuzzles.solved[this.transform.parent.name.Replace("(Clone)", "")];
    }

    void OnMouseDown()
    {
        print(this.transform.parent.name.Replace("(Clone)",""));
        if (!GetDicValue())
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            SceneManager.LoadScene(DiaryPage);
        }

    }

}
