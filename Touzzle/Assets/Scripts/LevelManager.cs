using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static int level = 5000;
    public int piecesAmount;
    public const float StartTime = 20;
    public const float StartRatio = 3;
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
        float ratio = -Mathf.Pow(level - 1, 1.1f) / StartTime + StartRatio;
        GetComponent<Timer>().maxTime = MaxTime();
        GetComponent<Timer>().Reset();
        piecesAmount = PiecesAmount(ratio);
        FindObjectOfType<LevelCounter>().Reset(piecesAmount);
        GetComponent<Shuffler>().NextPuzzle();
        level++;
    }

    public bool CheckLevel()
    {
        return FindObjectOfType<LevelCounter>().points >= piecesAmount;
    }

    int PiecesAmount(float ratio)
    {
        return (int)(MaxTime()/ratio);
    }

    float MaxTime()
    {
        return StartTime + (level-1)*StartTime*0.25f;
    }
}
