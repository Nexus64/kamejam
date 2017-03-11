﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceTable : MonoBehaviour {
	public List<Transform> pieces;
	public int targetPiece;
	List<Transform> positions; 
	public Transform test_transform;

	// Use this for initialization
	void Start () {
		positions = new List<Transform>(GetComponentsInChildren<Transform>());
		positions = positions.GetRange (1, 9);
		Debug.Log (positions.Count);
		List<Transform> testList = new List<Transform>();
		for (int i = 0; i < 9; i++) {
			testList.Add (Instantiate (test_transform));
		}
		AssignPieces (testList, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AssignPieces(List<Transform> pieces, int targetPiece){
		this.pieces = pieces;
		this.targetPiece = targetPiece;

		for(int i = 0; i<positions.Count; i++){
			Transform position = positions [i];
			foreach (Transform child in position){
				Destroy(child.gameObject);
			}
			pieces [i].SetParent (position);
			pieces [i].localPosition = Vector3.zero;
		}
	}
}
