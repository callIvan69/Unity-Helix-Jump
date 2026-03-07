using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform axis;
    [SerializeField] private Floor floorPrefab;

    [Header("Settings")]
    [SerializeField] private int defaulFloorAmont;
    [SerializeField] private float floorHeight;
    [SerializeField] private int emptySegmentsAmount;
    [SerializeField] private int minTrapSegments;
    [SerializeField] private int maxTrapSegments;

    private float floorAmount = 0;
    public float FloorAmount => floorAmount;

    private float lastFloorY = 0;
    public float LastFloorY => lastFloorY;

    public void Generate(int level)
    {
        DestroyChild();

        floorAmount += defaulFloorAmont + level;

        axis.transform.localScale = new Vector3(1, floorAmount * floorHeight + floorHeight, 1);

        for(int i = 0; i < floorAmount; i++)
        {
            Floor floor = Instantiate(floorPrefab, transform);
            floor.transform.Translate(0, i * floorHeight, 0);
            floor.name = "Floor " + i;

            if (i == 0)
            {
                floor.SetFinishSegment();
            }

            if(i > 0 && i < floorAmount - 1)
            {
                floor.SetRandomRotation();
                floor.AddEmptySegment(emptySegmentsAmount);
                floor.AddRandomTrapSegment(Random.Range(minTrapSegments, maxTrapSegments + 1));
            }

            if (i == floorAmount - 1)
            {
                lastFloorY = floor.transform.position.y;
                floor.AddEmptySegment(2);
            }
        }
    }
    private void DestroyChild()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i) == axis) continue;

            Destroy(transform.GetChild(i).gameObject);
        }
    }
}
