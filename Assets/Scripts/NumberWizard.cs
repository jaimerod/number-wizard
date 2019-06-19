using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
  [SerializeField] TextMeshProUGUI Guess;
  [SerializeField] int MaxGuess;
  [SerializeField] int MinGuess;

  // Start is called before the first frame update
  void Start()
  {
    Guess.text = RandomGuess().ToString();
  }

  public void Higher()
  {
    MinGuess = int.Parse(Guess.text);
    Guess.text = RandomGuess().ToString();
  }

  public void Lower()
  {
    MaxGuess = int.Parse(Guess.text);
    Guess.text = RandomGuess().ToString();
  }

  private int RandomGuess()
  {
    System.Random rand = new System.Random();
    return rand.Next(MinGuess, MaxGuess + 1);
  }
}
