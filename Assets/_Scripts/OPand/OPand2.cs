using UnityEngine;

public class OPand2 : MonoBehaviour
{
   

   public string id;
   public string pw;
   public int exp;
    

    void Start()
    {
       
        string _id = "superman";
        string _pw = "pw12345";
        int _exp = 1000;

       bool islogin = (_id == id && _pw == pw) || (exp >= _exp);

       Debug.Log(islogin);
        

    }

   
}
