using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Password : MonoBehaviour
{
    private string[] password = {"0","0","0","0"};
    private string[] correct = {"1","2","3","4"};

   
    public GameObject Y1;
    public GameObject Y2;
    public GameObject Y3;
    public GameObject Y4;
    
    public void Close(){
       SceneManager.LoadScene(3);
    }
    
    public void Enter(){
       if(password[0]==correct[0] && password[1]==correct[1] && password[2]==correct[2] && password[3]==correct[3]){
         Debug.Log("doğru");
         SceneManager.LoadScene(6);
       }

    }

    public void GetInput1(){
        
        if(password[0] == "0"){
            password[0] = "1";
            Y1.SetActive(true);
        }
        else if(password[1] == "0"){
            password[1] = "1";
            Debug.Log("b");
            Y2.SetActive(true);
        }
        else if(password[2] == "0"){
            password[2] = "1";
            Debug.Log("c");
            Y3.SetActive(true);
        }
        else if(password[3] == "0"){
            password[3] = "1";
            Debug.Log("d");
            Y4.SetActive(true);
        }
    }
    
    public void GetInput2(){
        
        if(password[0] == "0"){
            password[0] = "2";
            Y1.SetActive(true);
        }
        else if(password[1] == "0"){
            password[1] = "2";
            Y2.SetActive(true);
        }
        else if(password[2] == "0"){
            password[2] = "2";
            Y3.SetActive(true);
        }
        else if(password[3] == "0"){
            password[3] = "2";
            Y4.SetActive(true);
        }
    }
    
    public void GetInput3(){
        
        if(password[0] == "0"){
            password[0] = "3";
            Y1.SetActive(true);
        }
        else if(password[1] == "0"){
            password[1] = "3";
            Y2.SetActive(true);
        }
        else if(password[2] == "0"){
            password[2] = "3";
            Y3.SetActive(true);
        }
        else if(password[3] == "0"){
            password[3] = "3";
            Y4.SetActive(true);
        }
    }
   
    public void GetInput4(){
        
        if(password[0] == "0"){
            password[0] = "4";
            Y1.SetActive(true);
        }
        else if(password[1] == "0"){
            password[1] = "4";
            Y2.SetActive(true);
        }
        else if(password[2] == "0"){
            password[2] = "4";
            Y3.SetActive(true);
        }
        else if(password[3] == "0"){
            password[3] = "4";
            Y4.SetActive(true);
        }
    }

    public void GetInput5(){
        
        if(password[0] == "0"){
            password[0] = "5";
            Y1.SetActive(true);
        }
        else if(password[1] == "0"){
            password[1] = "5";
            Y2.SetActive(true);
        }
        else if(password[2] == "0"){
            password[2] = "5";
            Y3.SetActive(true);
        }
        else if(password[3] == "0"){
            password[3] = "5";
            Y4.SetActive(true);
        }
    }

    public void GetInput6(){
        
        if(password[0] == "0"){
            password[0] = "6";
            Y1.SetActive(true);
        }
        else if(password[1] == "0"){
            password[1] = "6";
            Y2.SetActive(true);
        }
        else if(password[2] == "0"){
            password[2] = "6";
            Y3.SetActive(true);
        }
        else if(password[3] == "0"){
            password[3] = "6";
            Y4.SetActive(true);
        }
    }

    public void GetInput7(){
        
        if(password[0] == "0"){
            password[0] = "7";
            Y1.SetActive(true);
        }
        else if(password[1] == "0"){
            password[1] = "7";
            Y2.SetActive(true);
        }
        else if(password[2] == "0"){
            password[2] = "7";
            Y3.SetActive(true);
        }
        else if(password[3] == "0"){
            password[3] = "7";
            Y4.SetActive(true);
        }
    }

    public void GetInput8(){
        
        if(password[0] == "0"){
            password[0] = "8";
            Y1.SetActive(true);
        }
        else if(password[1] == "0"){
            password[1] = "8";
            Y2.SetActive(true);
        }
        else if(password[2] == "0"){
            password[2] = "8";
            Y3.SetActive(true);
        }
        else if(password[3] == "0"){
            password[3] = "8";
            Y4.SetActive(true);
        }
    }

    public void GetInput9(){
        
        if(password[0] == "0"){
            password[0] = "9";
            Y1.SetActive(true);
        }
        else if(password[1] == "0"){
            password[1] = "9";
            Y2.SetActive(true);
        }
        else if(password[2] == "0"){
            password[2] = "9";
            Y3.SetActive(true);
        }
        else if(password[3] == "0"){
            password[3] = "9";
            Y4.SetActive(true);
        }
    }

}
  