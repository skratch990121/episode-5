using UnityEngine;

public class Userprofile : MonoBehaviour
{
    public string myname;
    public int power;

    void Start()
    {
        Print();
        SayHello();
    }
void Print()
{
 Debug.Log($"내 이름은 <color=green>{myname}</color> 이고 , 전투력은 <color=red>{power}</color> 입니다");

}

void SayHello()
{
    Debug.Log("안녕하세요");
}
}
