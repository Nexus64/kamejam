using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuffler : MonoBehaviour
{
    public List<Object> shapes;
    public List<Object> pictures;
   // public PieceTable board;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void shuffle()
    {
    }

    void Awake()
    {
        shapes = new List<Object>(Resources.LoadAll("Shapes"));
        pictures = new List<Object>(Resources.LoadAll("Pictures"));
    }
}
