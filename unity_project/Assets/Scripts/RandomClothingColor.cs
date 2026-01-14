using UnityEngine;

public class RandomClothingColor : MonoBehaviour
{
    private SkinnedMeshRenderer smr;

    void Start()
    {
        smr = GetComponent<SkinnedMeshRenderer>();
        if (smr == null) return;

        // material 인스턴스 강제 생성
        Material mat = smr.material;

        Color randomColor = new Color(
            Random.Range(0.1f, 1f),
            Random.Range(0.1f, 1f),
            Random.Range(0.1f, 1f)
        );

        // URP 대응
        if (mat.HasProperty("_BaseColor"))
        {
            mat.SetColor("_BaseColor", randomColor);
        }
        else
        {
            mat.color = randomColor;
        }
    }
}
