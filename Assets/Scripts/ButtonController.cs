using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{

    public Button[] buttons;

    private void Start()
    {
        for(int index=0;index<buttons.Length;index++)
        {
            AddButtonListener(buttons[index], index);
        }
    }

    private void AddButtonListener(Button buttons, int index)
    {
        int indexOfSceneToLoad = SceneManager.GetActiveScene().buildIndex + index + 1;
     
        buttons.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(indexOfSceneToLoad);  
        });
    }

}
