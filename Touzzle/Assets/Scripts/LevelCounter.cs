using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCounter : MonoBehaviour {
	string text = "Puntos: ";
	public int points;
	public int targetPoints;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void IncreasePoints(int points = 1)
	{
		this.points += points;
		GetComponent<Text>().text = text + this.points + "/" + targetPoints;
	}

	public void Reset(int targetPoints)
	{
		this.targetPoints = targetPoints+1; 
		points = -1;
        IncreasePoints(0);

    }
}
