using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour {
	public Sprite shape;
	public Sprite picture;
	public int rotation;
	public bool mirror;
	// Use this for initialization
	void Start () {
		UpdateProperties ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Copy(Piece piece){

	}

	public void UpdateProperties(){
		List<SpriteRenderer> childs = new List<SpriteRenderer>(GetComponentsInChildren<SpriteRenderer>());
		childs [0].sprite = picture;
		childs [1].sprite = shape;
	}
}
