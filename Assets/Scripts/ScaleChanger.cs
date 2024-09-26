using UnityEngine;
using DG.Tweening;

public class ScaleChanger : MonoBehaviour
{
    [SerializeField] private float _targetScale;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DOScale(Vector3.one * _targetScale, _duration)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
