using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Password : MonoBehaviour
{

    // public Buttons buttons;
    private string input;
    private int Pass;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ReadStringInput(string s){
        input = s;
        Debug.Log(input);
        if(input == "sude"){
            Pass = 1;
            if(Pass == 1){
                Debug.Log("Seden");
                

              // buttons.Meet_Open();
              // buttons.Meet_password_Close();

               // buttons.SwitchScene4();
               SceneManager.LoadScene(3);
            }    
       
        }
        else if(input!= "sude"){
            Debug.Log("Ceylin");

            //buttons.Meet_password_Close();
           
        }
    }



}
