using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private MovementBase playerBehaviour;

    [SerializeField]
    private Rigidbody projectil;

    private void Awake()
    {
        playerBehaviour = GetComponent<MovementBase>();
    }

    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        if (horizontal != 0 || vertical != 0)
        {
            playerBehaviour.Move(horizontal, vertical);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            CreateBullet();

        }
    }

    private void CreateBullet()
    {
        Instantiate(projectil, transform.position, Quaternion.identity);
    }
}



