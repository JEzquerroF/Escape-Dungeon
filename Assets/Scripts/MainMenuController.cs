using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    private void OnEnable()
    {
        MenuScript.OnMenuClick += ChangeScenes;
    }
    private void OnDisable()
    {
        MenuScript.OnMenuClick -= ChangeScenes;
    }

    public void ChangeScenes(MenuScript menu)
    {
        int option = menu.menuBarIndex;

        if (option == 0)
        {
            if (ChangeScene.currentScenes == 0)
            {
                SceneManager.LoadScene(ChangeScene.currentScenes + 1);
    
            }
            else
            {
                SceneManager.LoadScene(ChangeScene.currentScenes);
            }
        }

        else if (option == 1)
        {
            Application.Quit();
        }
    }
}
