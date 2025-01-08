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
    public int a;
    public int b;
    public int age = 20;
    public int age2 = 18;
    public int kg;
    public int kg2;

   
    [Header("연산자 결과")]
     
    [ReadOnly] public bool andOP; // AND 연산 결과
    [ReadOnly] public bool orOP; // OR 연산 결과
    [ReadOnly] public bool notOP; // NOT 연산 결과
    [ReadOnly] public bool ifOP; // 상황 연산 결과
    [ReadOnly] public string ifOPstring; // 상황 연산 문자 결과
    // [ReadOnly] public string ifOPstring2;

    [ReadOnly] public string agestring;
    [ReadOnly] public string kgstring;




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
        // Debug.Log($"{A == B}");
        // Debug.Log($"{A != B}");
        // Debug.Log($"{A <= B}");
        // Debug.Log($"{A >= B}");
        // Debug.Log($"{A < B}");
        // Debug.Log($"{A > B}");

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
        // bool result = (A == B) && (B == C);

        // Debug.Log(result);


    // 상황연산
    // 조건1 ? TRUE : FALSE;

    


    }


    void Update()
    {


        // bool result = (A == B) && (B == C);
        // andOP = result;
        // Debug.Log(andOP);

        // bool result2 = (A == B) || (B == C);
        // orOP = result2;
        // Debug.Log(orOP);

        // bool result3 = (A == B) ! (B == C);
        // notOP = result3;
        // Debug.Log(notOP);

        // ifOP = A == B ? true : false;

        // ifOPstring = A == B ? "A B 가 같다" : "A B 가 다르다";
         
        // ifOPstring2 = (a <= b) || (a >= b) ? "a b 는 성인이다" : "a b 는 성인이 아니다";

        

        // agestring = age > 19 ? "성인" : "미성년";

        agestring = isAdult(age);

        kgstring = isBMI(kg);
        

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



    
    // 19세이상이면 성인 19세이하면 미성년

    string isAdult(int a)
    {
        return agestring = a > 19 ? "성인" : "미성년";
    }
   

   string isBMI(int k)
   {

    return kgstring = k > 60 ? "과체중" : "저체중";

   }
   

}
