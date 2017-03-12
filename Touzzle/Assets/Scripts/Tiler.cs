using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiler : MonoBehaviour {
    public Sprite tile;
    public Color color;
    public bool parallax;
    public float speed;
	// Use this for initialization
	void Start () {
        foreach (var backgroundTile in GetComponentsInChildren<SpriteRenderer>())
        {
            backgroundTile.color = color;
            backgroundTile.sprite = tile;            
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (!parallax)
            return;
        foreach (Transform backgroundUnit in transform)
        {
            backgroundUnit.Translate(-speed * Time.smoothDeltaTime, 0, 0);
            if(backgroundUnit.position.x <= -15)
                backgroundUnit.position = new Vector3((backgroundUnit.position.x + 15 * 2), 0, 0);
        }
	}
}
