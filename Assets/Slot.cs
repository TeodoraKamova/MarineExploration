using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Slot : MonoBehaviour {

	Icon icon;
    public Image img;
	public void AddIcon(Icon newIcon)
    {
        icon = newIcon;
        img.sprite = icon.img;
        img.enabled = true;
    }
    public void ClearIcon()
    {
        icon = null;
        img.sprite = null;
        img.enabled = false;
    }
    public void Red()
    {
        if(icon!=null)
        icon.Redirect();
    }

}
