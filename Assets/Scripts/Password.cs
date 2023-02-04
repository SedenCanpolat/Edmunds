using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Password : MonoBehaviour
{
    private string[] password = {"0","0","0","0"};
    private string[] correct = {"1","1","1","1"};


    public void Enter(){
       if(password[0]==correct[0] && password[1]==correct[1] && password[2]==correct[2] && password[3]==correct[3]){
         Debug.Log("doğru");
       }

    }



    public void GetInput1(){
        
        if(password[0] == "0"){
            password[0] = "1";
            Debug.Log("a");
        }
        else if(password[1] == "0"){
            password[1] = "1";
            Debug.Log("b");
        }
        else if(password[2] == "0"){
            password[2] = "1";
            Debug.Log("c");
        }
        else if(password[3] == "0"){
            password[3] = "1";
            Debug.Log("d");
        }

    Debug.Log("ss");
    }
    
    public void GetInput2(){
        
        if(password[0] == "0"){
            password[0] = "2";
        }
        else if(password[1] == "0"){
            password[1] = "2";
        }
        else if(password[2] == "0"){
            password[2] = "2";
        }
        else if(password[3] == "0"){
            password[3] = "2";
        }
    }
    
    public void GetInput3(){
        
        if(password[0] == "0"){
            password[0] = "3";
        }
        else if(password[1] == "0"){
            password[1] = "3";
        }
        else if(password[2] == "0"){
            password[2] = "3";
        }
        else if(password[3] == "0"){
            password[3] = "3";
        }
    }
   
    public void GetInput4(){
        
        if(password[0] == "0"){
            password[0] = "4";
        }
        else if(password[1] == "0"){
            password[1] = "4";
        }
        else if(password[2] == "0"){
            password[2] = "4";
        }
        else if(password[3] == "0"){
            password[3] = "4";
        }
    }

    public void GetInput5(){
        
        if(password[0] == "0"){
            password[0] = "5";
        }
        else if(password[1] == "0"){
            password[1] = "5";
        }
        else if(password[2] == "0"){
            password[2] = "5";
        }
        else if(password[3] == "0"){
            password[3] = "5";
        }
    }

    public void GetInput6(){
        
        if(password[0] == "0"){
            password[0] = "6";
        }
        else if(password[1] == "0"){
            password[1] = "6";
        }
        else if(password[2] == "0"){
            password[2] = "6";
        }
        else if(password[3] == "0"){
            password[3] = "6";
        }
    }

    public void GetInput7(){
        
        if(password[0] == "0"){
            password[0] = "7";
        }
        else if(password[1] == "0"){
            password[1] = "7";
        }
        else if(password[2] == "0"){
            password[2] = "7";
        }
        else if(password[3] == "0"){
            password[3] = "7";
        }
    }

    public void GetInput8(){
        
        if(password[0] == "0"){
            password[0] = "8";
        }
        else if(password[1] == "0"){
            password[1] = "8";
        }
        else if(password[2] == "0"){
            password[2] = "8";
        }
        else if(password[3] == "0"){
            password[3] = "8";
        }
    }

    public void GetInput9(){
        
        if(password[0] == "0"){
            password[0] = "9";
        }
        else if(password[1] == "0"){
            password[1] = "9";
        }
        else if(password[2] == "0"){
            password[2] = "9";
        }
        else if(password[3] == "0"){
            password[3] = "9";
        }
    }
}

  