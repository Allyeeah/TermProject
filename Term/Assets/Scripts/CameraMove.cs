using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    private void Update()
    {
        transform .position= target.position+offset;
    }
}
