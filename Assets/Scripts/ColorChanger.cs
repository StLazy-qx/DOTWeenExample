using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Renderer))]

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;

    private Renderer _objRenderer;

    private void Awake()
    {
        _objRenderer = GetComponent<Renderer>();
    }

    private void Start()
    {
        _objRenderer.material.DOColor(_color, _duration)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
