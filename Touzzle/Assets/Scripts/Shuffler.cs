using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuffler : MonoBehaviour
{
	List<Sprite> shapes;
	List<Sprite> pictures;
    public PieceTable board;



    // Use this for initialization
    void Start()
    {
        shuffle();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void shuffle()
    {
        foreach (var piece in board.GetComponentsInChildren<Piece>())
        {
			Debug.Log (piece.shape.name);
            piece.shape = (Sprite)shapes[Random.Range(0, shapes.Count)];
			Debug.Log ("   "+piece.shape.name);
            piece.picture = (Sprite)pictures[Random.Range(0, shapes.Count)];
			piece.UpdateProperties ();
        }
        board.GetComponent<PieceTable>().targetPiece = Random.Range(0, 9);
    }

    void Awake()
    {
		shapes = new List<Sprite>(Resources.LoadAll<Sprite>("Shapes"));
		pictures = new List<Sprite>(Resources.LoadAll<Sprite>("Pictures"));
    }
}
