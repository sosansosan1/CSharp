using UnityEngine;

//���� �̿��� ������ ���� : bool, char, string
//char(����) : ���� ������ ����
public class CharacterDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] char �� ���� ���� �� �ʱ�ȭ
        char grade = 'A';
        char kor = '��';

        //[2] ����ϱ�
        Debug.Log("grade: " + 'A');
        Debug.Log("kor: " + '��');

        Debug.Log(grade);
        Debug.Log(kor);
    }
}
