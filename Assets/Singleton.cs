using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    public class Singleton : MonoBehaviour 
    {
      /*  public static Singleton Instance { get; set; }
        public dairyIU diaryUI { get; set; }
        public Transform Parr;
        public Slot[] slots;
        public Diary diary;
        // Use this for initialization
        public void init()
        {
            diary = Diary.instance;
            diary.onIconChangedCallBack += UpdateUI;
            slots = Parr.GetComponentsInChildren<Slot>(true);
        }
        void UpdateUI()
        {
            for (int i = 0; i < slots.Length; i++)
            {
                if (i < diary.icons.Count)
                {
                    slots[i].AddIcon(diary.icons[i]);
                }
            }
        }

        private void Awake()
        {
            // If there is an instance, and it's not me, delete myself.
            if (Instance != null && Instance != this)
            {
                Destroy(this);
            }
            else
            {
                Instance = this;
                diaryUI = GetComponentInChildren<dairyIU>();
            }
        }

        void Start()
        {
            //diaryUI = GameObject.Find("diaryUI").GetComponentInChildren<dairyIU>();
            Singleton.Instance.diaryUI.init();
        }*/
    }
}
