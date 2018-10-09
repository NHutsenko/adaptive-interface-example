using UnityEngine;

public class CanvasSetup : MonoBehaviour {

    [SerializeField] private GameObject _pauseButton;
    [SerializeField] private GameObject _homeButton;
    [SerializeField] private GameObject _settingsButton;
    [SerializeField] private GameObject _retumeButton;

    private void Awake() {
        gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width, Screen.height);
        SetParams(_pauseButton, 15, -20, -10);
        SetParams(_homeButton, 15, -10, 0);
        SetParams(_settingsButton, 15, 0, 0);
        SetParams(_retumeButton, 15, 10, 0);
    }

    private void SetParams(GameObject toSetup, float sizeScaler, float xPosScaler, float yPosScaler) {
        var pos = new Vector2();
        if (xPosScaler == 0) {
            pos = new Vector2(0, Screen.height / yPosScaler);
        }
        if (yPosScaler == 0) {
            pos = new Vector2(Screen.width / xPosScaler, 0);
        }
        if (xPosScaler == 0 && yPosScaler == 0) {
            pos = new Vector2(0, 0);
        } 
        if(xPosScaler != 0 && yPosScaler != 0) {
            pos = new Vector2(Screen.width / xPosScaler, Screen.height / yPosScaler);
        }

        toSetup.GetComponent<RectTransform>().anchoredPosition = pos;
        toSetup.GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width / sizeScaler, Screen.width / sizeScaler);
    }
}
