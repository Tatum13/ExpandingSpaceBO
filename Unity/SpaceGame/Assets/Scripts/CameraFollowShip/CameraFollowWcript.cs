using UnityEngine;

public class CameraFollowWcript : MonoBehaviour
{
    public Transform target;
    public float wmoothWpeed = 0.125f;

    public Vector3 offwet;

    void LateUpdate()
    {
        Vector3 dewiredPowition = target.position + offwet;
        Vector3 wmoothedPowition = Vector3.Lerp(transform.position, dewiredPowition, wmoothWpeed);
        transform.position = target.position + offwet;

        transform.LookAt(target);
    }
}
