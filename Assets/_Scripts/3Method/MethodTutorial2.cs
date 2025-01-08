using UnityEngine;

public class MethodTutorial2 : MonoBehaviour
{
  
    public MethodTutorial1 mt;

    public int num1 = 5;
    public int num2 = 10;

    public int a, b;

    void Start()
    {
        int temp = mt.Add(a, b);

        mt.Method2();
        mt.Add(a, b);
       
        
        Debug.Log(temp);
       
       
    }

    
}
