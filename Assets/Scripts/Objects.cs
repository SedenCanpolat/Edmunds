using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Objects : MonoBehaviour
{
    
    public void openCase(){
       SceneManager.LoadScene(5);
    }
    
    public void weaponScene(){
        SceneManager.LoadScene(6);
    }

    public void letterScene(){
        SceneManager.LoadScene(7);
    }


}
