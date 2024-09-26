using UnityEngine;
using DG.Tweening;

public class Rotater : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private float _angleRotateY;
    [SerializeField] private float _angleRotateZ;

    private void Start()
    {
        transform.DORotate(new Vector3(0, _angleRotateY, _angleRotateZ),
            _duration, RotateMode.FastBeyond360)
            .SetLoops(-1, LoopType.Incremental)
            .SetEase(Ease.Linear);
    }
}
