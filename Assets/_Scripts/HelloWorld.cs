
using JetBrains.Annotations;
using UnityEngine;
class HelloWorld : MonoBehaviour
{
    public int number;
    public int number2;
    public int number3;
    public int number4;
    public int number5;
    public string text;
    public string text2 = "텍스트2";
    public string text3 = "+";
    public string text4 = "=";

        private void Start()
    {
        Debug.Log("<b><color=red>시작</color></b>\n" + $"<b><color=blue>{number}</color></b>" + " " + $"<color=yellow>{text}</color>");
        Debug.Log($"{number} {text2} {number2}");
        Debug.Log($"{number3}{text3}{number4}{text4}{number5}");
        Debug.Log($"{number3}+{number4}={number3+number4}");

    
        
       
    }


}