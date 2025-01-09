using TMPro;

using UnityEngine;

public class CalculatorUi : MonoBehaviour
{
    // 인포 연결
    [SerializeField] private TextMeshProUGUI tmpinfo;
    [SerializeField] private TextMeshProUGUI tmpinfo2;
    [SerializeField] private TextMeshProUGUI tmpinfo3;

    // 타이틀 연결
    [SerializeField] private TextMeshProUGUI tmptitle;
    [SerializeField] private TextMeshProUGUI tmptitle2;
    [SerializeField] private TextMeshProUGUI tmptitle3;

    // 인포
    [HideInInspector] public string info;
    [HideInInspector] public string info2;
    [HideInInspector] public string info3;

    // 타이틀
    [HideInInspector] public string title;
    [HideInInspector] public string title2;
    [HideInInspector] public string title3;


    [Header("입력값")]
    public int A;
    public int B;

  
   void Update()
   {    
        //더하기
        info = $"{Add(A, B)}";
        tmpinfo.text = info;
        title = $"{A} + {B} =";
        tmptitle.text = title; 

        //나누기
        info2 = $"{Div(A, B)}";
        tmpinfo2.text = info2;
        title2 = $"{A} ÷ {B} =";
        tmptitle2.text = title2; 

        //나머지
        info3 = $"{Mod(A, B)}";
        tmpinfo3.text = info3;
        title3 = $"{A} % {B} =";
        tmptitle3.text = title3; 


   }

    // 덧셈 메소드를 만든다
    // A,B를 입력받는다
    // 결과를 tmpinfo에 출력받는다


    // 더하기 메소드
    int Add(int a, int b)
    {
        return a + b;
    }

    // 나누기 메소드
    float Div(float a, float b)
    {
        return a / b;
    }

    // 나머지 메소드
    int Mod(int a, int b)
    {
        return a % b;
    }
}
