using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static int level = 1;
    public int piecesAmount;
// Use this for initialization
void Start()
    {
        LoadLevel();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadLevel()
    {
        GetComponent<Timer>().maxTime = MaxTime();
        GetComponent<Timer>().Reset();
        piecesAmount = PiecesAmount();
        FindObjectOfType<LevelCounter>().Reset();
        GetComponent<Shuffler>().NextPuzzle();
        level++;
    }

    public bool CheckLevel()
    {
        return FindObjectOfType<LevelCounter>().points >= piecesAmount;
    }

    int PiecesAmount()
    {
        return (int)(2+(level-1)*0.667f);
    }

    float MaxTime()
    {
        return 20 + (level-1)*10f;
    }
}
