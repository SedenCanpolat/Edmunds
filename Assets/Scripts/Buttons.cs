using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    } 

    //SWITCH SCENE
   public void SwitchScene1(){
    SceneManager.LoadScene(1);
   }
   

    public void SwitchScene2(){
        SceneManager.LoadScene(2);
    }

    public void SwitchScene3(){
        SceneManager.LoadScene(3);
    }

    public void SwitchScene4(){
        SceneManager.LoadScene(4);
    }

    //DİALOG

    public void Dialog2(){
        SceneManager.LoadScene(8);
    }
    public void Dialog3(){
        SceneManager.LoadScene(9);
    }
    public void Dialog4(){
        SceneManager.LoadScene(10);
    }

      public void SwitchScene13(){
        SceneManager.LoadScene(13);
    }

      public void SwitchScene12(){
        SceneManager.LoadScene(12);
    }

    public void SwitchScene14(){
        SceneManager.LoadScene(14);
    }

    public void SwitchScene15(){
        SceneManager.LoadScene(15);
    }

    public void SwitchScene0(){
    SceneManager.LoadScene(0);
   }

    public void SwitchScene17(){
    SceneManager.LoadScene(17);
    
   }

}









