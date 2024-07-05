using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneTriggerButton : MonoBehaviour
{
    public Button button;
    public TextMeshProUGUI textMeshPro;

    public void LoadFinalSceneAndHideUI()
    {
        // Hide the Button and TextMeshPro
        button.gameObject.SetActive(false);
        textMeshPro.gameObject.SetActive(false);

        // Load the "final" scene
        SceneManager.LoadScene("ampliopia buttons");
    }
}