using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level1 : MonoBehaviour
{
    public string levelToLoad;
    private float timer = 10f;
    private Text timerSeconds;
    // Start is called before the first frame update
    void Start()
    {
        timerSeconds = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
//        timerSeconds.text = timer.ToString("f2");
        if(timer <= 0){
           SceneManager.LoadScene(13);
        }
        
    }
     public void SwitchScene1(){
        SceneManager.LoadScene(1);
    }
}
