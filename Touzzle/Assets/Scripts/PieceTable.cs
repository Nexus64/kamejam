using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PieceTable : MonoBehaviour {
	public List<Piece> pieces;
	public int targetPiece;
	List<Transform> positions;
	public Shuffler shuffler;
    AudioSource sound;
    public AudioClip correctSound;
    public AudioClip wrongSound;

    // Use this for initialization
    void Awake () {
		pieces = new List<Piece>(GetComponentsInChildren<Piece>());
        sound = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

	internal void CheckPiece(Piece piece)
	{
		if (piece.Equals(pieces[targetPiece]))
		{
            if (shuffler.GetComponent<LevelManager>().CheckLevel())
            {
                SceneManager.LoadScene("Interlude");
            }
            else
            {
                sound.PlayOneShot(correctSound, 1F);
                shuffler.NextPuzzle();
            }
		}
		else
		{
            sound.PlayOneShot(wrongSound, 1F);
            shuffler.GetComponentInParent<Timer>().TimePenalty();
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
