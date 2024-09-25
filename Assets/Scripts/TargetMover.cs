using UnityEngine;

public class TargetMover : DoObjectChanger
{
    [SerializeField] private Transform _target;

    private void Start()
    {
        ChangePosition(_target);
    }
}
