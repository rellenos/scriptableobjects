using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{

    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;
    public TextMeshProUGUI text4;

    public void SetLanguage(Language language)
    {
        text1.text=language.Text1;
        text2.text=language.Text2;
        text3.text=language.Text3;
        text4.text=language.Text4;
    }
}
