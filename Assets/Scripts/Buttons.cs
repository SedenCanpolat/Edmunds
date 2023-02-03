using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneManager;

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
}









