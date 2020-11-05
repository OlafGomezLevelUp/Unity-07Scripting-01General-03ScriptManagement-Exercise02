using UnityEngine;

public class MovementTransformBehaviour : MovementBase
{
    public override void Move(float horizontal, float vertical, float depth)
    {
        var direction = new Vector3(horizontal, vertical, 0);
        transform.Translate(direction * speedDataSO.Speed * Time.deltaTime);
    }
}
