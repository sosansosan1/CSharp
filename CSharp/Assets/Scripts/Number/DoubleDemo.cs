using UnityEngine;

public class DoubleDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float f = 3.14f;        //32비트 실수형 데이터 형식 선언 및 초기화
        double pi = 3.141592;   //64비트 실수형 데이터 형식 선언 및 초기화
        decimal d = 12.34m;     //128비트 실수형 데이터 형식 선언 및 초기화

        Debug.Log(f);
        Debug.Log(pi);
        Debug.Log(d);

        double doublemin = double.MinValue;
        double doublemax = double.MaxValue;

        Debug.Log("double 최대값 : " + doublemin);
        Debug.Log("double 최대값 : " + doublemax);

        float floatmin = float.MinValue;
        float floatmax = float.MaxValue;

        Debug.Log("float 최대값 : " + floatmin);
        Debug.Log("float 최대값 : " + floatmax);

        decimal decimalmin = decimal.MinValue;
        decimal decimalmax = decimal.MaxValue;

        Debug.Log("decimal 최대값 " + decimalmin);
        Debug.Log("decimal 최대값 " + decimalmax);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
