using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToMainMenuScreen : MonoBehaviour
{
    public Button button;
    public string sceneName;

    private void Start() {
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick() {
        SceneManager.LoadScene("Menu");
    }
}


/*using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour {
    public Button button;
    public string sceneName;

    private void Start() {
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick() {
        SceneManager.LoadScene(sceneName);
    }
}*/
