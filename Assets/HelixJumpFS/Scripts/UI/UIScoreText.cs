using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIScoreText : BallEvents
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private ScoreCollector scoreCollector;

    protected override void OnBallCollisionSegmet(SegmentType type)
    {
       if (type != SegmentType.Trap)
       {
            scoreText.text = scoreCollector.Score.ToString();
       }
    }
}
