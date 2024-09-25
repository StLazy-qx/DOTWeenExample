using UnityEngine;

public class ColorChanger : DoObjectChanger
{
    [SerializeField] private Color _color;

    private void Start()
    {
        ChangeColor(_color);
    }
}
