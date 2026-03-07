using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpot : BallEvents
{
    [SerializeField] private Transform parentTransform;
    [SerializeField] private MeshRenderer visualMeshRenderer;
    [SerializeField] private Blot blotPrefab;

    protected override void OnBallCollisionSegmet(SegmentType type)
    {
        if(type != SegmentType.Empty)
        {
            Blot blot = Instantiate(blotPrefab, parentTransform);
            blot.Init(new Vector3(visualMeshRenderer.transform.position.x, transform.position.y, visualMeshRenderer.transform.position.z), visualMeshRenderer.material.color);
        }
    }
}
