using UnityEngine;

// ConstantDemo(���) : ������ �ʴ� ����, �б����� ����
public class ConstantDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ���� ������ ��� ����� ���ÿ� �ʱ�ȭ
        const int MAX = 100;


        //[2] ��� ����ϱ�
        Debug.Log("�ִ밪: " + 100);
    }
}
