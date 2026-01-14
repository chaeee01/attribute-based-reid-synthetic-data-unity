using UnityEngine;

public class RandomRotate : MonoBehaviour
{
    public Vector3 minRotation = new Vector3(0, 0, 0);
    public Vector3 maxRotation = new Vector3(0, 360, 0);

    void Start()
    {
        float x = Random.Range(minRotation.x, maxRotation.x);
        float y = Random.Range(minRotation.y, maxRotation.y);
        float z = Random.Range(minRotation.z, maxRotation.z);

        transform.rotation = Quaternion.Euler(x, y, z);
    }
}
