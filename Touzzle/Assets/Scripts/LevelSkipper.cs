using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent (typeof(AudioSource))]
public class LevelSkipper : MonoBehaviour {
    public string targetScene;
    AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        audioSource.Play();
        SceneManager.LoadScene(targetScene);
        
    }
}
