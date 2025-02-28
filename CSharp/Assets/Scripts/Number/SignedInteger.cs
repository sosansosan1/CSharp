using UnityEngine;

public class SignedInteger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //SignedInteger
        sbyte isbyte = 127; //8비트 부호가 있는 정수형 변수 선언 및 초기화
        short iInt16 = 32767; //16비트 부호가 있는 정수형 변수 선언 및 초기화
        int iInt32 = 2147483647; //32비트 부호가 있는 정수형 변수 선언 및 초기화
        long iInt64 = 9223372036845775807; //64비트 부호가 있는 정수형 변수 선언 및 초기화

        Debug.Log("sbyte: " + isbyte);
        Debug.Log("short: " + iInt16);
        Debug.Log("int: " + iInt32);
        Debug.Log("long: " + iInt64);

        //UnSignedInteger
        byte ibyte = 255; //8비트 부호가 없는 정수형 변수 선언 및 초기화
        ushort iUInt16 = 65535; //16비트 부호가 없는 정수형 변수 선언 및 초기화
        uint iUInt32 = 4294967295; //32비트 부호가 없는 정수형 변수 선언 및 초기화
        ulong iUInt64 = 18446744073709551615; //64비트 부호가 없는 정수형 변수 선언 및 초기화

        Debug.Log("byte: " + ibyte);
        Debug.Log("ushort: " + iUInt16);
        Debug.Log("uint: " + iUInt32);
        Debug.Log("ulong: " + iUInt64);
    }
}

/* 
1 Bit 0, 1

1 Byte : 8 Bit

0000 0000   -> 0
0000 0001   -> 1
0000 0010   -> 2
0000 0011   -> 3
0000 0100   -> 4

8bit
(+, -, 0)
sbyte : -128 ~ 127

(+, 0)
byte : 0 ~ 255

SignedInteger (+, -) 부호가 있는 정수형 데이터 형식(타입) 
 
UnSignedInteger (+, -) 부호가 없는 정수형 데이터 형식(타입)
*/