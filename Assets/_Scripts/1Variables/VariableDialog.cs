using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class VariableDialog : MonoBehaviour
{
    [Header("대화상대")]   
    public string player1;

    public string player2; 


    
        

    [Header("대화")]
        public string dlg1;
        public string dlg2;
        public string dlg3;
        public string dlg4;
        public string dlg5;
        public string dlg6;
        public string dlg7;
        public string dlg8;
        public string dlg9;
        public string dlg10;

        public string dlg11;

    [Header("데이터")]
        public float temperature;

    [Header("시간")]
        public int time;

        public bool answer;

        public int num1;
        public int num2;

        public int num3;

 

   

    void Start()
    {

        string d1 = $"{player1} {dlg1}\n";
        string d2 = $"{player2} {dlg2}\n";
        string d3 = $"{player1} {temperature} {dlg3}\n";
        string d4 = $"{player2} {dlg4}\n";
        string d5 = $"{player1} {dlg5}\n";
        string d6 = $"{player2} {time} {dlg6}\n";
        string d7 = $"{player1} {dlg7}\n";
        string d8 = $"{player2} {answer} {dlg8}\n";
        string d9 = $"{player1} {num1} {dlg10} {num2} {dlg9}\n";
        string d10 = $"{player2} {num3} {dlg11}\n";
        

        string dialog = d1 + d2 + d3 + d4 + d5 + d6 + d7 + d8 + d9 + d10;

        Debug.Log(dialog);
        
    }
}
