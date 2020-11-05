using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MovementRigidbodyBehaviour : MovementBase
{
    private Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        Vector3 mousePosition = GetCurrentMousePoisition();

        Move(mousePosition.x, mousePosition.y);
    }
    

    public override void Move(float horizontal, float vertical, float depth)
    {
        var direction = new Vector3(horizontal, vertical, 0);
        var projectileDelta = direction - transform.position;
        rigidbody.AddForce(projectileDelta.normalized * speedDataSO.Speed);
    }

    private Vector3 GetCurrentMousePoisition()
    {
        var mouseInput = Input.mousePosition;
        mouseInput.z = 10;
        var mousePosition = Camera.main.ScreenToWorldPoint(mouseInput);
        mousePosition.z = 0;
        return mousePosition;
    }
}
