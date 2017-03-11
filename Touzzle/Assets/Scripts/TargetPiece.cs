using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPiece : MonoBehaviour {
	PieceTable table;
	// Use this for initialization
	void Start () {
		PickTargetPiece(table);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PickTargetPiece(PieceTable table){
		Piece piece = table.pieces [table.targetPiece].GetComponent<Piece>();

	}
}
