using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
	public float maxTime;
	public float countdown;
	public Slider slider;
    public Image fill;
    public Color fillMax, fillMin;
    AudioSource clock;
	// Use this for initialization
	void Start () {
        clock = GetComponent<AudioSource>();
		Reset();
	}
	
	// Update is called once per frame
	void Update () {
		countdown -= Time.deltaTime;
		slider.value = countdown / maxTime;
        
        if ((int)((1 - slider.value) * 100) % 20 == 0 && slider.value > 0.1)
        {
            clock.volume = (1 - slider.value) * 0.8f + 0.2f;
            clock.pitch = (1 - slider.value) * 1.4f + 0.6f;
            fill.color = Color.Lerp(fillMax, fillMin, 1-slider.value);
        }
        if (countdown <= 0)
        {
            LevelManager.level = 1;
            SceneManager.LoadScene("GameOver");
        }
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
