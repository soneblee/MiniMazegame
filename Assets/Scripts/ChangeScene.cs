using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeSceneBtn()
    {
        switch(this.gameObject.name)
        {
            case "Start":
                SceneManager.LoadScene("MapScene");
                break;
            case "StageButton1":
                SceneManager.LoadScene("stage1");
                break;
            case "StageButton2":
                SceneManager.LoadScene("stage2");
                break;
            case "StageButton3":
                SceneManager.LoadScene("stage3");
                break;
            case "RecipeBook":
                SceneManager.LoadScene("Recipe");
                break;
        }
    }
}
