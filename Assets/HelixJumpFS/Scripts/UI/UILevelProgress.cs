using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UILevelProgress : BallEvents
{
    [SerializeField] private LevelProgress levelProgress;
    [SerializeField] private LevelGenerator levelGenerator;

    [SerializeField] private TMP_Text currentLevelText;
    [SerializeField] private TMP_Text nextLevelText;
    [SerializeField] private Image progressBar;

    private float fillAmountStep;

    
    private void Start()
    {
        currentLevelText.text = levelProgress.CurrentLevel.ToString();
        nextLevelText.text = (levelProgress.CurrentLevel + 1).ToString();
        progressBar.fillAmount = 0;

        fillAmountStep = 1 / levelGenerator.FloorAmount;
    }
    protected override void OnBallCollisionSegmet(SegmentType type)
    {
        if(type == SegmentType.Finish || type == SegmentType.Empty)
        {
            progressBar.fillAmount += fillAmountStep;
        }

    }
}
