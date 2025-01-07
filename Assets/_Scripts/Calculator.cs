using JetBrains.Annotations;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    void Start()
    {
        Debug.Log($"{num1}");
        Debug.Log($"{num2}");
        Debug.Log($"{add(1,2)}");
        Debug.Log($"{minus(1,2)}");
        Debug.Log($"{fusion(1,2)}");
        Debug.Log($"{defulicated(1,2)}");
        Debug.Log($"{num1 + num2}");
       
        
    }
    public int num1;
    public int num2;

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
