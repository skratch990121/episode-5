using System.ComponentModel;
using UnityEngine;

public class OPand : MonoBehaviour
{
    [Header("입력창")]
    public bool a;
    public bool b;
    public int nc;
   
    [Header("결과창")]
    [ReadOnly] public bool opSame; 
    [ReadOnly] public bool opDiff; 
    [ReadOnly] public bool opGreater; 
    [ReadOnly] public bool opSmaller; 




      
    void Update()
    {
        bool isSame = a == b;  
        opSame = isSame;               

        bool isDiff = a != b;
        opDiff = isDiff;

        bool isGreater = nc > 10;
        opGreater = isGreater;

        bool isSmaller = nc < 10;
        opSmaller = isSmaller;

    }

}
