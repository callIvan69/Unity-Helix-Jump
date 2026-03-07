using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class LevelColors
{
    public Color AxisColor;
    public Color BallColor;
    public Color SegmentColor;
    public Color BackgroundColor;
    public Color CameraBackgroundColor;
}

public class ChangeColors : MonoBehaviour
{
    [SerializeField] private LevelColors[] levelColors;

    [SerializeField] private Material axisMaterial;
    [SerializeField] private Material ballMaterial;
    [SerializeField] private Material segmentMaterial;
    [SerializeField] private Image backgroundImage;
    [SerializeField] private Camera cameraBackground;

    private void Start()
    {
        int index = Random.Range(0, levelColors.Length);

        axisMaterial.color = levelColors[index].AxisColor;
        ballMaterial.color = levelColors[index].BallColor;
        segmentMaterial.color = levelColors[index].SegmentColor;
        backgroundImage.color = levelColors[index].BackgroundColor;
        cameraBackground.backgroundColor = levelColors[index].CameraBackgroundColor;
    }
}
