using UnityEngine;

public class StringPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string 고추 = "홀수";
        const int num = 3;

        Debug.Log($"{num}은(는) {고추} 입니다");
    }
}

/*
[Q]
3, 홀수를 변수 선언하고 저장한다
문자열 보간법을 이용해서 저장된 데이터 출력하기

[output]
3은(는) 홀수 입니다
*/