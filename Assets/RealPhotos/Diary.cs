using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Diary : MonoBehaviour {

    public dairyIU dairy;
    public static Diary instance;
    void Start()
    {
        dairy.ClearSlots();
        dairy.Init();
    }
    void Awake()
    {
        if(instance!=null)
        {
            Debug.LogWarning("More than one diary");
        }
        //instance = this;
        //DontDestroyOnLoad(this);
        if (instance == null) // If there is no instance already
        {
            DontDestroyOnLoad(gameObject); // Keep the GameObject, this component is attached to, across different scenes
            instance = this;
        }
        else if (instance != this) // If there is already an instance and it's not `this` instance
        {
            Destroy(gameObject); // Destroy the GameObject, this component is attached to
        }
    }
    public delegate void OnIconChanged();
    public OnIconChanged onIconChangedCallBack;
	public List<Icon> icons = new List<Icon>();

	public void Add(Icon icon)
    {
        if(!icons.Contains(icon))
        {
            icons.Add(icon);
            if(onIconChangedCallBack != null)
            {
                onIconChangedCallBack.Invoke();
            }
        }
        
    }

}
