using UnityEngine;

public abstract class MovementBase : MonoBehaviour
{
    [SerializeField]
    protected SpeedDataSO speedDataSO;


    public void Move(float horizontal, float vertical)
    {
        Move(horizontal, vertical, 0f);
    }

    public abstract void Move(float horizontal, float vertical, float depth);
}
