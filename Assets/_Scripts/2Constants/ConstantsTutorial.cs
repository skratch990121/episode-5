// 네임 스페이스 영역
using UnityEngine;

// 클래스 영역
public class ConstantsTutorial : MonoBehaviour
{
    #region 멤버변수

    // Attribute
    [Header("스코어")]
    public int score1;
    private const int Max_Score = 100;

    [ReadOnly]
    public int score3;


   
    #endregion

    #region 상수

    #endregion


    #region 메소드 (함수)

        private void Start()
        {
            
            
            Debug.Log($"{Max_Score}");
        }
    

    #endregion

    // 업데이트 에서 score1 -> score3 값을 전달

        private void Update()
    {
        
        score3 = score1;

        Debug.Log($"{score3}");
    }
}
