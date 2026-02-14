using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LifeUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
     
    public void ChangeHPUI(int hp)
    {
        _text.text = hp.ToString();
    }


}
