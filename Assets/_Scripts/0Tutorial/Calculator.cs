// 네임스페이스
using UnityEngine;

// 클래스
public class Calculator : MonoBehaviour
{
    // 메소드, 함수 서브루틴 ( Method, Function, SubRoutine )
    void Start()
    {
        // 메소드를 이용하여 계산
        // 메소드를 호출 ( Method Call )
        Debug.Log($"{num1}");
        Debug.Log($"{num2}");
        Debug.Log($"{add(1,2)}");
        Debug.Log($"{minus(1,2)}");
        Debug.Log($"{fusion(1,2)}");
        Debug.Log($"{defulicated(1,2)}");
        Debug.Log($"{num1 + num2}");
       
        
    }
    // 멤버 변수 ( Variables )
    public int num1;
    public int num2;

// 메소드를 선언 ( Method Declare )
int add(int num1 , int num2)
{
    return num1 + num2;
}

int minus(int num1 , int num2)
{
    return num1 - num2;
}

int fusion(int num1 , int num2)
{
    return num1 * num2;

}

int defulicated(int num1 , int num2)
{
    return num1 / num2;
}
}
