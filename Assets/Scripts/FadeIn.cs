using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeInUI : MonoBehaviour
{
    public Image panel; // Assign your panel here
    public Button button; // Assign your button here
    public float fadeDuration = 1f; // Duration for the fade-in
    public float buttonDelay = 1f; // Delay before the button starts to fade in

    void Start()
    {
        // Set the initial alpha value of the button to 0
        Color buttonColor = button.image.color;
        buttonColor.a = 0;
        button.image.color = buttonColor;

        StartCoroutine(FadeInPanel());
    }

    IEnumerator FadeInPanel()
    {
        // Delay before starting the button fade-in
        yield return new WaitForSeconds(buttonDelay);

        // Fade in the panel
        Color panelColor = panel.color;
        float startPanelAlpha = panelColor.a;
        float panelRate = 1.0f / fadeDuration;
        float panelProgress = 0.0f;

        while (panelProgress < 1.0f)
        {
            panelColor.a = Mathf.Lerp(startPanelAlpha, 1, panelProgress);
            panel.color = panelColor;
            panelProgress += panelRate * Time.deltaTime;
            yield return null;
        }

        panelColor.a = 1;
        panel.color = panelColor;

        // Start fading in the button after the delay
        StartCoroutine(FadeInButton());
    }

    IEnumerator FadeInButton()
    {
        // Wait for a short time to ensure the button feedback is visible
        yield return new WaitForSeconds(0.1f);

        // Ensure the button's alpha is full, but modify tint colors for visual feedback
        ColorBlock cb = button.colors;
        cb.normalColor = new Color(143f / 255f, 143f / 255f, 143f / 255f, 1f);
        cb.highlightedColor = new Color(255f / 255f, 255f / 255f, 255f / 255f, 1f);
        cb.pressedColor = new Color(255f / 255f, 255f / 255f, 255f / 255f, 1f);
        cb.selectedColor = new Color(255f / 255f, 255f / 255f, 255f / 255f, 1f);
        cb.disabledColor = new Color(143f / 255f, 143f / 255f, 143f / 255f, 1f);
        button.colors = cb;

        // Fade in the button
        Color buttonColor = button.image.color;
        float startButtonAlpha = buttonColor.a;
        float buttonRate = 1.0f / fadeDuration;
        float buttonProgress = 0.0f;

        while (buttonProgress < 1.0f)
        {
            buttonColor.a = Mathf.Lerp(startButtonAlpha, 1, buttonProgress);
            button.image.color = buttonColor;
            buttonProgress += buttonRate * Time.deltaTime;
            yield return null;
        }

        buttonColor.a = 1;
        button.image.color = buttonColor;
    }
}
