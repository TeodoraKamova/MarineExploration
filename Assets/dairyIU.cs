using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dairyIU : MonoBehaviour {

	public Transform Parr;
    public Slot[] slots;
    Diary diary;
    public static dairyIU dairyUI;
  
    void Awake()
    {
        if (dairyUI != null)
        {
            Debug.LogWarning("More than one diary");
        }
        dairyUI = this;
        //DontDestroyOnLoad(this.Parr);
    }
    // Use this for initialization
    public void Init () { 
		diary = Diary.instance;
		diary.onIconChangedCallBack += UpdateUI;
		slots = Parr.GetComponentsInChildren<Slot>(true);
	}
	
	// Update is called once per frame
	void Update () {
	}
	void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
			if(i<diary.icons.Count)
            {
				slots[i].AddIcon(diary.icons[i]);
            }
        }
    }
    public void ClearSlots()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            slots[i].ClearIcon();
        }
    }

}
