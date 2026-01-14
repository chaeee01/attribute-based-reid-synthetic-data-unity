using UnityEngine;

public class PantsColorRandom : MonoBehaviour
{
    public SkinnedMeshRenderer pantsRenderer;

    public Color[] colors;

    void Start()
    {
        Randomize();
    }

    public void Randomize()
    {
        if (pantsRenderer == null || colors.Length == 0) return;

        Color c = colors[Random.Range(0, colors.Length)];
        pantsRenderer.material.color = c;
    }
}
