using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;

    private string _textPrefab1 = "��� ��������� ����� ���� �� ������;";
    private string _textPrefab2 = "������ ��������� - ������� ��� ��!";
    private string _textPrefab3 = "�� � ������� - ��������� ���������";
    private WaitForSeconds wait;
    private float _delay = 2;

    private void Awake()
    {
        wait = new WaitForSeconds(_delay);

        StartCoroutine(WriteTextDelay());
    }

    private IEnumerator WriteTextDelay()
    {
        yield return wait;

        Write();
    }

    private void Write()
    {
        _text.DOText(_textPrefab1, _duration).OnComplete(() =>
            _text.DOText(_textPrefab2, _duration).SetRelative().OnComplete(() =>
                _text.DOText(_textPrefab3, _duration, true, ScrambleMode.All)));
    }
}
