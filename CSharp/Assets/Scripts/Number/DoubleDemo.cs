using UnityEngine;

public class DoubleDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float f = 3.14f;        //32��Ʈ �Ǽ��� ������ ���� ���� �� �ʱ�ȭ
        double pi = 3.141592;   //64��Ʈ �Ǽ��� ������ ���� ���� �� �ʱ�ȭ
        decimal d = 12.34m;     //128��Ʈ �Ǽ��� ������ ���� ���� �� �ʱ�ȭ

        Debug.Log(f);
        Debug.Log(pi);
        Debug.Log(d);

        double doublemin = double.MinValue;
        double doublemax = double.MaxValue;

        Debug.Log("double �ִ밪 : " + doublemin);
        Debug.Log("double �ִ밪 : " + doublemax);

        float floatmin = float.MinValue;
        float floatmax = float.MaxValue;

        Debug.Log("float �ִ밪 : " + floatmin);
        Debug.Log("float �ִ밪 : " + floatmax);

        decimal decimalmin = decimal.MinValue;
        decimal decimalmax = decimal.MaxValue;

        Debug.Log("decimal �ִ밪 " + decimalmin);
        Debug.Log("decimal �ִ밪 " + decimalmax);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
