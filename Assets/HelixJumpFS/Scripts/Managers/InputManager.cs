using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : BallEvents
{
    [SerializeField] private MouseRotator inputRotator;

    protected override void OnBallCollisionSegmet(SegmentType type)
    {
        if(type == SegmentType.Trap || type == SegmentType.Finish)
        {
            inputRotator.enabled = false;
        }
    }
}
