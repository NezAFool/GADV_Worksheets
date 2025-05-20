using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTracker 
{
    // Start is called before the first frame update
    private int score = 10;
    public ScoreTracker(int Score)
    {
        score = Score;
        Debug.Log($"Score:{score}");
    }
    public void resetScore()
    {
        score = 0;
    }
}
