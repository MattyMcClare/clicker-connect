using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OldPhoneCounterDisplay : MonoBehaviour
{
    TextMeshProUGUI counter;
    OldPhoneGame oldPhoneGame;

    void Start()
    {
        counter = GetComponent<TextMeshProUGUI>();
        oldPhoneGame = FindObjectOfType<OldPhoneGame>();
    }
    void Update()
    {
        counter.text = oldPhoneGame.GetCounter().ToString();
    }
}
