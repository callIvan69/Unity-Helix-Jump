using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCollector : BallEvents
{
    [SerializeField] private LevelProgress levelProgress;
    [SerializeField] private int score;
    [SerializeField] TMP_Text hightScoreText;
    public int Score => score;

    protected override void OnBallCollisionSegmet(SegmentType type)
    {
        if(type == SegmentType.Empty)
        {
            score += levelProgress.CurrentLevel;
        }
    }
}
