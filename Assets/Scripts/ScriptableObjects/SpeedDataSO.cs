using UnityEngine;

[CreateAssetMenu(fileName = "SpeedDataSO", menuName = "Data/SpeedSO")]
public class SpeedDataSO : ScriptableObject
{
    [SerializeField]
    private float speed;

    public float Speed
    {
        get { return speed; }
        private set { speed = value; }
    }
}
