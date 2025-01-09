using Unity.Collections;
using UnityEngine;

public class GetLength : MonoBehaviour
{

    // public string s;
    // public int resulta;

        int a = 11;
        int b = 8;
    // public int resultb;
    
    void Start()
    {

        Debug.Log($"a = {a} , b = {b}");

        

        Debug.Log($"a = {a} , b = {b}");
        
        // int i = getLength(s);
        //  Debug.Log(i);

        // int x = SwitchVar(resulta , resultb);
        // int y = SwitchVar2(resulta , resultb);

        // Debug.Log(x);
        // Debug.Log(y);

    }

    
    // int getLength(string x)
    // {
    //     int i = x.Length;
    //     return i;
    // }

    // int SwitchVar(int a , int b)
    // {
    //     int x = (a = b);
    //     return x;
    // }

    // int SwitchVar2(int a , int b)
    // {
    //      int y = (b = a);
    //      return y;
    // }

    void SwitchVar()
    {
        int temp;
        temp = a;
        a = b;
        b = temp;
    }

    void SwitchVar2(int a, int b, out int oa, out int ob)
    {
        int temp;
        temp = a;
        oa = b;
        ob = temp;
    }
}
