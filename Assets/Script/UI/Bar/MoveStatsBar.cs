using Newtonsoft.Json.Linq;
using Sirenix.OdinInspector;
using UnityEngine;

public class MoveStatsBar: MonoBehaviour
{
    [SerializeField]
    private Transform moveSprite;
    [SerializeField]
    private Vector3 posMaxMove;
    [SerializeField]
    private Vector3 startSpritePos;

    public float MaxValue;

    [Button]
    public void MoveStats(float value)
    {
        value = Mathf.Clamp(value, 1, MaxValue);
        moveSprite.localPosition = Vector3.Lerp(posMaxMove, startSpritePos, value / MaxValue);
    }
    [Button]
    public void ValueRestart()
{
        moveSprite.localPosition = Vector3.Lerp(posMaxMove, startSpritePos, 1);
    }

}
