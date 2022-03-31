using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pontuacao : MonoBehaviour
{
  public Text myText;
	public static int pontos;
    void Start()
    {
		pontos=12;
    }
    void Update()
    {
		   myText.text = pontos+"";
    }
}
