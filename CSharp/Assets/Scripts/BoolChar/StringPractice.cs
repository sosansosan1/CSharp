using UnityEngine;

public class StringPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string ���� = "Ȧ��";
        const int num = 3;

        Debug.Log($"{num}��(��) {����} �Դϴ�");
    }
}

/*
[Q]
3, Ȧ���� ���� �����ϰ� �����Ѵ�
���ڿ� �������� �̿��ؼ� ����� ������ ����ϱ�

[output]
3��(��) Ȧ�� �Դϴ�
*/