using UnityEngine;

public class RealNumberPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float f = 3.14f;
        double d = 3.14d;
        decimal m = 3.14m;

        Debug.Log("float: " + f);
        Debug.Log("double: " + d);
        Debug.Log("decimal: " + m);
    }
}

/*
[Q]
�Ǽ��� �� float 3.14, double 3.14, secimal 3.14 �� ����ϱ�

[output]
float: 3.14
double: 3.14
decimal: 3.14
*/