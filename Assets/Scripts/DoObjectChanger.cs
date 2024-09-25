using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Renderer))]

public abstract class DoObjectChanger : MonoBehaviour
{
    [SerializeField] protected float Duration;

    private Renderer _objRenderer;

    private void Awake()
    {
        _objRenderer = GetComponent<Renderer>();
    }

    protected void ChangePosition(Transform target)
    {
        transform.DOMove(target.position, Duration)
            .SetLoops(-1, LoopType.Yoyo);
    }

    protected void Rotate(float angleRotateY, float angleRotateZ)
    {
        transform.DORotate(new Vector3(0, angleRotateY, angleRotateZ), Duration, RotateMode.FastBeyond360)
        .SetLoops(-1, LoopType.Incremental)
        .SetEase(Ease.Linear);
    }

    protected void ChangeScale(float value)
    {
        transform.DOScale(Vector3.one * value, Duration).SetLoops(-1, LoopType.Yoyo);
    }

    protected void ChangeColor(Color color)
    {
        _objRenderer.material.DOColor(color, Duration).SetLoops(-1, LoopType.Yoyo);
    }
}
