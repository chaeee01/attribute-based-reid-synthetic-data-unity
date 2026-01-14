using UnityEngine;

public class HatToggleSimple : MonoBehaviour
{
    [Range(0f, 1f)]
    public float wearProbability = 0.5f;

    void Start()
    {
        bool wearHat = Random.value < wearProbability;
        gameObject.SetActive(wearHat);
    }
}
