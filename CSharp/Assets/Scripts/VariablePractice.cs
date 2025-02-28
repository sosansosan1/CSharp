// PlayerController.cs
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public GameObject bulletPrefab;
    public Transform firePoint;

    void Update()
    {
        float move = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * move * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}


public class VariablePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 변수 선언
        int first, second, third;

        //[2] 변수에 값 저장
        first = 10;
        second = 20;
        third = 30;

        Debug.Log(first + ", " + second + ", " + third);
    }
}
