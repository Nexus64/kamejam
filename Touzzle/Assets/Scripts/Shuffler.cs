using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuffler : MonoBehaviour
{
    List<Object> shapes;
    List<Object> pictures;
    public PieceTable board;
    public GameObject piece;
    public List<GameObject> pieces;

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
        for(int i = 0; i < 9; i++)
            pieces.Add(Instantiate(piece));

        board.AssignPieces(pieces, 0);
    }

    void Awake()
    {
        shapes = new List<Object>(Resources.LoadAll("Shapes"));
        pictures = new List<Object>(Resources.LoadAll("Pictures"));
    }
}
