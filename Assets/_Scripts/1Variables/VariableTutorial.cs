
using UnityEngine;

public class VariableTutorial : MonoBehaviour
{
    // 멤버 변수의 영역
    [SerializeField] private int health; // 초기값 0 세팅

        // Start 는 초기값 세팅 역할
    void Start()
    {
        // health 에 저장된 값을 확인 하고싶다

        // 새로운 캐릭터 마다 체력 설정 을 적용
        health = 300; // 기획상 의 설정값 을 적용

        // Debug.Log() 는 콘솔창에 값을 출력하는 역할
        Debug.Log($"health : {health}");
    }

    // Update 는 실시간으로 변화하는 값을 반영
        void Update()
    {
        Debug.Log($"health : {health}");
    }
    }
