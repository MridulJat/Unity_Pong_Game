
using UnityEngine;
using DG.Tweening;
public class ball_movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D RB;
    [SerializeField] private float speed;
    [SerializeField] private Vector3 start;
    [SerializeField] private Transform rotation;
    void Launch()
    {
        float X_Movement = Random.Range(0, 2) == 0 ? -1 : 1;
        float Y_Movement = Random.Range(0, 2) == 0 ? -1 : 1;
        RB.velocity = new Vector2(speed * X_Movement, speed * Y_Movement);
    }

    void ball_rotate()
    {
        rotation.DORotate(new Vector3(0, 0, 0),0.2f).SetEase(Ease.Linear)
            .From(new Vector3(0,0,90)).SetLoops(-1,LoopType.Incremental);
    }
    void Start()
    {
        start = transform.position;
        ball_rotate();
        Launch();
    }

    public void ResetBall()
    {
        RB.velocity = new Vector2(0, 0);
        transform.position = start;
        Launch();
    }
}
