using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BackButtonController : MonoBehaviour
{
    public Button button;
    public string backScene;
    
    void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        Debug.Log("Button Clicked to Back");
        SceneManager.LoadScene(backScene);
    }
}
