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
		shape = piece.shape;
		picture = piece.picture;
		rotation = piece.rotation;
		mirror = piece.mirror;
		UpdateProperties ();
	}

	public void UpdateProperties(){
		List<SpriteRenderer> childs = new List<SpriteRenderer>(GetComponentsInChildren<SpriteRenderer>());
		childs [0].sprite = picture;
		childs [1].sprite = shape;
	}

    bool Equals(Piece other)
    {
        return shape.name == other.shape.name &&
               picture.name == other.picture.name &&
               rotation == other.rotation &&
               mirror == other.mirror;

    }
}
