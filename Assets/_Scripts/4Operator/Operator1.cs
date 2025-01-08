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

    void Start()
    {
        
        float mod = modulo(A, B);
        string result = $"나머지 연산 = {mod}";

        
        
        Debug.Log(result);


    }

    
    public float modulo(float a, float b)
    {
        return a % b;
    }
}
