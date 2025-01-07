using UnityEngine;

public class VariableType : MonoBehaviour
{
    //
    // 정수 타입
    //
    [Header("정수 타입")]
    // int : -21억4천만 ~ 21억4천만 , 크기 : 4 byte = 32 bit
    public int intType = 0;

    // long : -920경 ~ 920경 , 크기 : 8 byte = 64 bit
    public long longType = 0;

    // short : -32768 ~ 32767 , 크기 : 2 byte = 16 bit
    public short shortType = 0;

    // byte : 255 , 크기 : 1 byte
    public byte byteType = 0;
    
    void Update()
    {
        //Debug.Log($"플로트타입(floatType) = {floatType}");
        //Debug.Log($"바이트타입(byteType) = {byteType}");
        //Debug.Log($"쇼트타입(shortType) = {shortType}");
        //Debug.Log($"롱타입(LongType) = {longType}");
        // Debug.Log($"정수(integer) = {intType}");
        // sizeof(int) = 무언가의 크기를 가져오는 함수 

    }


    void Start()
    {
        Debug.Log(sizeof(float));
        Debug.Log(sizeof(int));
        Debug.Log(sizeof(long));
        Debug.Log(sizeof(short));
        Debug.Log($"결과 : int : {sizeof(int)} , long : {sizeof(long)} , short : {sizeof(short)} , byte : {sizeof(byte)} , float : {sizeof(float)}");
    }
        //
        // 실수 타입
        //
        [Header("실수 타입")]
        // float : -3.402823e+38 ~ 3.402823e+38 , 크기 : 4

    public float floatType;
    
}

