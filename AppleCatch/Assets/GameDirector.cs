using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

    GameObject timeText;
    GameObject pointText;
    float time = 60.0f;
    int point = 0;

    public void GetApple()
    {
        this.point += 100;
    }

    public void Getbomb()
    {
        this.point /= 2;
    }

	// Use this for initialization
	void Start () {
        this.timeText = GameOject.Find("Time");
        this.pointText = GameObject.Find("Point");
	}
	
	// Update is called once per frame
	void Update () {
        this.time -= time.deltaTime;
        this.timeText.GetComponent<Text>().text =
            this.time.ToString("F1");
        this.pointText.GetComponent<Text>().text =
            this.point.ToSring() + " point";
	}
}
