using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;
    void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }
    public void OnPressLower()
        {
            max = guess - 1;
        NextGuess();
    }
    void NextGuess()
    {
        guess = (min + max) / 2;
        guessText.text = guess.ToString();  
    }
}

