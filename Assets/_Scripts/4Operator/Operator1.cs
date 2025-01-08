using System.Globalization;
using UnityEngine;

public class Operator : MonoBehaviour
{
    
    // 연산자 (Operator)
    // + : 덧셈
    // - : 뺄셈
    // * : 곱셈
    // / : 나눗셈
    // % : 나머지


    public float A;
    public float B;
    public float C;

    [Header("연산자 결과")]
    [ReadOnly]
    public bool andOP; // AND 연산 결과
    public bool orOP; // OR 연산 결과
    public bool notOP; // NOT 연산 결과

    void Start()
    {
        
        // float mod = modulo(A, B);
        // string result = $"나머지 연산 = {mod}";

        // Debug.Log(result);

        // 5 , 8

        // 비교연산자 (왼쪽 기준)
        // == ? False (같다)
        // != ? True  (다르다)
        // <= ? True  (이하)
        // >= ? False (이상)
        // < ? True   (미만)
        // > ? False  (초과)

        // bool A op B ? 16 >= 7 : True

        // 숫자
        Debug.Log($"{A == B}");
        Debug.Log($"{A != B}");
        Debug.Log($"{A <= B}");
        Debug.Log($"{A >= B}");
        Debug.Log($"{A < B}");
        Debug.Log($"{A > B}");

        // 문자
        // Debug.Log($"{tA == tB}");
        // Debug.Log($"{tA != tB}");
        // Debug.Log($"{tA.Length <= tB.Length}");
        // Debug.Log($"{tA.Length >= tB.Length}");
        // Debug.Log($"{tA.Length < tB.Length}");
        // Debug.Log($"{tA.Length > tB.Length}");
        

        // 논리 연산
        // && 그리고 (AND) : 모두가 참 일때 True
        // || 또는   (OR)  : 둘중 하나만 참 일때 True
        // !  아니다 (NOT) : 


        // 반환 : True, False 순서 ()
        bool result = (A == B) && (B == C);

        Debug.Log(result);



    }


    void Update()
    {


        bool result = (A == B) && (B == C);
        andOP = result;
        Debug.Log(andOP);

        bool result2 = (A == B) || (B == C);
        orOP = result2;
        Debug.Log(orOP);

        // bool result3 = (A == B) ! (B == C);
        // notOP = result3;
        // Debug.Log(notOP);

    }

    // 나머지 연산자
    public float modulo(float a, float b)
    {
        return a % b;
    }


    // bool : True, False
    // 비교 연산
    // bool compareOp(int x, int y)
    // {
    //     // == : ? 같으면 True, 다르면 False
    //     return x == y;
    // }

}
