using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class MethodTutorial1 : MonoBehaviour
{
   private void Start()
    {

        Method1();

        int addresult;

       addresult = Add(a, b);
        
        Debug.Log($"{addresult}");

        
        
    }

    // 지역 -> 멤버 변수
     int volume = 10;
     public int volume2;

     public int num1 = 5;
     public int num2 = 10;
     public int a, b;

     

    // 메소드 선언
    private void Method1(/* infut, 파라미터 */)
    {

        // (지역) 변수
        
        Debug.Log($"{volume}");

    }


    public void Method2()
    {
        Debug.Log($"{volume}");
    }

    public int Add(int a, int b)
    {

        return a + b;

    }

    // Add 메소드 만들기, MethodTutorial2 멤버변수 A,B 만들고 값을 로그로 출력

}
