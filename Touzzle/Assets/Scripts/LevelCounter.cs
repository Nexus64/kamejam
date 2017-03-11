using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCounter : MonoBehaviour {
	string text = "Puntos:  ";
	public int points;
	// Use this for initialization
	void Start () {
		Reset();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void IncreasePoints(int points = 1)
	{
		this.points += points;
		GetComponent<Text>().text = text + this.points;
	}

	public void Reset()
	{
		points = -1;
	}
}
