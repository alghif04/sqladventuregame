using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI textComponent; // The text component for displaying dialogue
    public Image spriteImage; // The image component for displaying the sprite
    public string[] lines; // The array of dialogue lines
    public Sprite[] sprites; // The array of sprites corresponding to each line
    public float textSpeed; // The speed at which the text is displayed

    private int index; // The current index in the lines array

    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        spriteImage.sprite = sprites[index];
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            spriteImage.sprite = sprites[index];
            StartCoroutine(TypeLine());
        }
        // When the last line is reached, do nothing to keep it displayed
    }
}
