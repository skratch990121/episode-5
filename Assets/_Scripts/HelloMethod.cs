using UnityEngine;

public class HelloMethod : MonoBehaviour
{
    
       void Start()
    {
        // Method1(1);
        // Method1(2);
        // Method1(3);
        // Method1(4);

        // Method2("skratch");
        // Debug.Log($"{Method3(2,3)}");
        Debug.Log($"{Method1(99)}");
    
    }

int Method1(int attack)
{
    // Debug.Log($"공격력 {attack} 입니다");

    return attack + 10;
}

void Method2(string myname)
{
    Debug.Log($"내이름은 {myname} 입니다");
}

int Method3(int damage1 , int damage2)
{
    return damage1 + damage2;
}

}

