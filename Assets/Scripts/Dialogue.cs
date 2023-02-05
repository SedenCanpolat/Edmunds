using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    int index;
    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            if(textComponent.text == lines[index]){
                NextLine();
            }
        }
        else{
            StopAllCoroutines();
            textComponent.text = lines[index];   
        }  
    }


    void StartDialogue(){
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine(){
        foreach(char c in lines[index].ToCharArray()){
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine(){
         Scene scene =  SceneManager.GetActiveScene();
        if(index < lines.Length - 1){
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else if(scene.name == "12Diolog1") {
            SceneManager.LoadScene(1);
        }
        else if(scene.name == "13Dialog1.2") {
            SceneManager.LoadScene(1);
        }
        else if(scene.name == "8Dialog2") {
            SceneManager.LoadScene(2);
        }
        else if(scene.name == "9Dialog3") {
            SceneManager.LoadScene(3);
        }
        else if(scene.name == "10Dialog4") {
            SceneManager.LoadScene(4);
        }
        
    }

}
