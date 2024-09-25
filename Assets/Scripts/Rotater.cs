using UnityEngine;

public class Rotater : DoObjectChanger
{
    [SerializeField] private float _angleRotateY;
    [SerializeField] private float _angleRotateZ;

    private void Start()
    {
        Rotate(_angleRotateY, _angleRotateZ);
    }
}
