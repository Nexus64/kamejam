using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuffler : MonoBehaviour
{
    List<Sprite> shapes;
    List<Sprite> pictures;
    public PieceTable board;
    public TargetPiece targetPiece;



    // Use this for initialization
    void Start()
    {
        Shuffle();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Shuffle()
    {
        int targetIndex = Random.Range(0, shapes.Count);
        var pieces = board.GetComponentsInChildren<Piece>();
        var target = pieces[targetIndex];
        RandomizePiece(target);

        for (int i = 0; i < pieces.Length; i++)
        {
            var piece = pieces[i];
            if (i==targetIndex)
                continue;
                
            do
                RandomizePiece(piece);
            while (piece.Equals(target));
        }
        board.GetComponent<PieceTable>().targetPiece = targetIndex;
        targetPiece.PickTargetPiece(board);
    }

    void RandomizePiece(Piece piece)
    {
        piece.shape = (Sprite)shapes[Random.Range(0, shapes.Count)];
        piece.picture = (Sprite)pictures[Random.Range(0, shapes.Count)];

        int seed = Random.Range(0, 7);
        if (seed % 2 == 1)
            piece.mirror = true;
        piece.rotation = (int)(seed / 2);

        piece.UpdateProperties();
    }

    void Awake()
    {
        shapes = new List<Sprite>(Resources.LoadAll<Sprite>("Shapes"));
        pictures = new List<Sprite>(Resources.LoadAll<Sprite>("Pictures"));
    }
}
