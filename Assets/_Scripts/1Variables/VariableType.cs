using System.Threading.Tasks.Sources;
using Unity.VisualScripting;
using UnityEditor.ShaderGraph.Internal;
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
        // Debug.Log(sizeof(float));
        // Debug.Log(sizeof(int));
        // Debug.Log(sizeof(long));
        // Debug.Log(sizeof(short));
        // Debug.Log($"결과 : int : {sizeof(int)} , long : {sizeof(long)} , short : {sizeof(short)} , byte : {sizeof(byte)} , float : {sizeof(float)}");
        
        // floatType = 3.141592f;
        // Debug.Log($"플로트타입(floatType) = {floatType}");
        
        // doubleType = 3.14;
        // Debug.Log($"더블타입(doubleType) = {doubleType}");

        // intType = (int)3.14;

        // Debug.Log($"인트타입(intType) = {intType}");

        // floatType = (float)intType;
        // Debug.Log($"{floatType}");

        // stringType.Length 

        // string result = $"문자 내용은 {stringType}입니다";
        
        // string result2 = $"문자의 길이는 {stringType.Length}입니다";


        // Debug.Log(result2);
        // 부울의 크기
        string boolsize = $"boolsize = {sizeof(bool)}";
        
        // 부울의 값
        string boolvalue = $"boolvalue = {boolType}";
        
        
        Debug.Log(boolvalue);

    }

        //
        // 실수 타입
        //
        [Header("실수 타입")]
       

    // float : -3.402823e+38 ~ 3.402823e+38 , 크기 : 4 byte
    // public float floatType = 0.0f;
    // // double : 8 byte
    // public double doubleType = 0.0;
    // // decimal : 16 byte
    // public decimal decimalType = 0;

    [Header("문자타입")]
    public string stringType = "";
    
    [Header("부울타입")]
    // 값 : True or False , 크기 : byte
    public bool boolType;
    
}

