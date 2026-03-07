using UnityEngine;

public abstract class BallEvents : MonoBehaviour
{
    [SerializeField] protected BallController ballController;
    protected virtual void Awake()
    {
        ballController.CollisionSegment.AddListener(OnBallCollisionSegmet);
    }
    protected virtual void OnDestroy()
    {
        ballController.CollisionSegment.RemoveListener(OnBallCollisionSegmet);
    }
    protected virtual void OnBallCollisionSegmet(SegmentType type)
    {
        
    }
}