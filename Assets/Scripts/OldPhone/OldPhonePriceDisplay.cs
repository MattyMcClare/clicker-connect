using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OldPhonePriceDisplay : MonoBehaviour
{
    TextMeshProUGUI price;
    OldPhoneGame oldPhoneGame;

    void Start()
    {
        price = GetComponent<TextMeshProUGUI>();
        oldPhoneGame = FindObjectOfType<OldPhoneGame>();
    }
    void Update()
    {
        price.text = oldPhoneGame.GetPrice().ToString();
    }
}
