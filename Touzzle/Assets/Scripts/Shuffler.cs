using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuffler : MonoBehaviour
{
    List<Object> shapes;
    List<Object> pictures;
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
            piece.shape = (Sprite)shapes[Random.Range(0, shapes.Count)];
            piece.picture = (Sprite)pictures[Random.Range(0, shapes.Count)];
        }
        board.GetComponent<PieceTable>().targetPiece = Random.Range(0, 9);
    }

    void Awake()
    {
        shapes = new List<Object>(Resources.LoadAll("Shapes"));
        pictures = new List<Object>(Resources.LoadAll("Pictures"));
    }
}
