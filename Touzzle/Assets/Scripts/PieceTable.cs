using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceTable : MonoBehaviour {
	public List<Piece> pieces;
	public int targetPiece;
	List<Transform> positions;
    public Shuffler shuffler;

	// Use this for initialization
	void Awake () {
		pieces = new List<Piece>(GetComponentsInChildren<Piece>());

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    internal void CheckPiece(Piece piece)
    {
        if (piece.Equals(pieces[targetPiece]))
        {
            shuffler.Shuffle();
        }
    }

    //public void AssignPieces(List<Piece> pieces, int targetPiece){
    //	this.pieces = pieces;
    //	this.targetPiece = targetPiece;

    //	for(int i = 0; i<positions.Count; i++){
    //		Transform position = positions [i];
    //		foreach (Transform child in position){
    //			Destroy(child.gameObject);
    //		}
    //		pieces[i].transform.SetParent(position);
    //		pieces[i].transform.localPosition = Vector3.zero;
    //	}
    //}
}
