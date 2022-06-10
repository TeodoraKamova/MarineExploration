using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButOnClick : MonoBehaviour {

    public bool CorrOrIncorr;
    public string DiaryPageName;
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject CurrentFish;
    public static int heartCount = 2;
    public Icon icon;


    public void OnButtonPress()
    {
        print("button pressed");
        if(CorrOrIncorr)
        {
            //smth like that -- Get the name of the object GameObject
            //print(GameObject.Find("GameObject").transform.GetChild(0).name);
            //and change the value in the dictionary of that name to true
            SolvedPuzzles.solved[GameObject.Find("GameObject").transform.GetChild(0).name] = true;
            //CurrentFish.GetComponent<Click>().found = true;
            //print(CurrentFish.GetComponent<Click>().found);
            Diary.instance.Add(icon);
            SceneManager.LoadScene("firstscene");
            new WaitForSeconds(3);
            SceneManager.LoadScene(DiaryPageName);
        }
        else 
        {
            if (heartCount == 2)
            {
                DestroyHeart(Heart1);
                heartCount--;
            }
            else if (heartCount == 1)
            {
                DestroyHeart(Heart2);
                heartCount = 2;
                SceneManager.LoadScene("firstscene");
            }
            
        }
       
    }
    void DestroyHeart(GameObject h)
    {
        Destroy(h);
    }

}
