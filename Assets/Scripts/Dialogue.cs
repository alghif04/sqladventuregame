using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Add this to access Scene Management

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public Sprite[] sprites;
    public Image spriteImage;

    private int index;

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
        StartCoroutine(TypeLine());
        UpdateSprite();
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
            StartCoroutine(TypeLine());
            UpdateSprite();
        }
        else
        {
            LoadNextScene(); // Call method to load the next scene
        }
    }

    void UpdateSprite()
    {
        if (index < sprites.Length && sprites[index] != null)
        {
            spriteImage.sprite = sprites[index];
            spriteImage.enabled = true;
        }
        else
        {
            spriteImage.enabled = false;
        }
    }

    void LoadNextScene()
    {
        // Replace "NextScene" with the actual name of your next scene
        SceneManager.LoadScene("Map-1");
    }
}
