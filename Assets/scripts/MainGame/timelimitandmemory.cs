using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class timelimitandmemory : MonoBehaviour {

    public int clearcount = 0;
    public bool zenkaiclear = false;
    public Texture2D tex;
    public Font f;
    private GUIStyle labelStyle;
    float timer;
    // Use this for initialization
    void Start () {

        this.labelStyle = new GUIStyle();
        this.labelStyle.fontSize = Screen.height / 20;
        this.labelStyle.normal.textColor = Color.white;
        labelStyle.font = f;
        DontDestroyOnLoad(this);
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.fixedDeltaTime;
        if (zenkaiclear)
        {
            zenkaiclear = false;
            clearcount++;
        }
	}
    void OnGUI()
    {
        string s = string.Format("{0}Seconds Left", 100-(int)timer);
        string str= string.Format("Score : {0}", (int)clearcount);
        GUI.Label(new Rect(1550, 50, 100, 30), str, labelStyle);
        GUI.Label(new Rect(20, 50, 100, 30), s, labelStyle);
    }
}
