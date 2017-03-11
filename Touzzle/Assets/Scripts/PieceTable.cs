using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceTable : MonoBehaviour {
	public List<Piece> pieces;
	public int targetPiece;
	List<Transform> positions; 
	public Transform test_transform;

	// Use this for initialization
	void Start () {
		pieces = new List<Piece>(GetComponentsInChildren<Piece>());
		pieces = pieces.GetRange (1, 9);
	}
	
	// Update is called once per frame
	void Update () {
		
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
