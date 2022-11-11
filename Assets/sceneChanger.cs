using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
 
public class sceneChanger: MonoBehaviour {
    public string SceneName;

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene(SceneName);
        }
    }
}