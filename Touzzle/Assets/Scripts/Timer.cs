using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	public float maxTime;
	public float countdown;
	public Slider slider;
	// Use this for initialization
	void Start () {
		Reset();
	}
	
	// Update is called once per frame
	void Update () {
		countdown -= Time.deltaTime;
		slider.value = countdown / maxTime;
	}

	public void TimePenalty(float penaltyPercent = 0.25f)
	{
		var penalty = maxTime * penaltyPercent;
		countdown -= penalty;
	}

	public void Reset()
	{
		countdown = maxTime;
		slider.value = 1;
	}
}
