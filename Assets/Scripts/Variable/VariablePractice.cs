using UnityEngine;

public class VariablePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int first = 10;
        int second = 20;
        int third = 30;

        Debug.Log(first + ", " + second + ", " + third);
    }
}


/*
[Q]
변수 : first, second, third 정의하고 값 대입하여 아래내용 출력

[output]
10,20,30
*/