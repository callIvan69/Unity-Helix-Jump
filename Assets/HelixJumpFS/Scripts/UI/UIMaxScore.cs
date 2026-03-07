using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMaxScore : BallEvents
{
    [SerializeField] private TMP_Text hightScoreText;
    [SerializeField] private ScoreCollector scoreCollector;

    private int hightScore;

    protected override void Awake()
    {
        base.Awake();
        hightScore = PlayerPrefs.GetInt("HightScore");
    }
    protected override void OnBallCollisionSegmet(SegmentType type)
    {
        if (type != SegmentType.Trap)
        {
            hightScoreText.text = hightScore.ToString();

            if (scoreCollector.Score >= hightScore)
            {
                hightScore = scoreCollector.Score;

                PlayerPrefs.SetInt("HightScore", hightScore);
            }
        }
    }
}
