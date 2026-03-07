using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SegmentType
{
    Default,
    Trap,
    Empty,
    Finish
}
[RequireComponent(typeof(MeshRenderer))]
public class Segment : MonoBehaviour
{
    [SerializeField] private Material finishMaterial;
    [SerializeField] private Material trapMaterial; 

    [SerializeField] private SegmentType type;

    public SegmentType Type => type;

    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void SetTrap()
    {
        meshRenderer.material = trapMaterial;
        meshRenderer.enabled = true;

        type = SegmentType.Trap;
    }
    public void SetEmpty()
    {
        meshRenderer.enabled = false;

        type = SegmentType.Empty;
    }

    public void SetFinish()
    {
        meshRenderer.enabled = true;
        meshRenderer.material = finishMaterial;

        type = SegmentType.Finish;
    }

}
