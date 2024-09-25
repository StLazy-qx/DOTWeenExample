using UnityEngine;

public class ChangeScale : DoObjectChanger
{
    [SerializeField] private float _targetScale;

    private void Start()
    {
        ChangeScale(_targetScale);
    }
}
