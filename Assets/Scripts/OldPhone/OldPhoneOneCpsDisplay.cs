using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OldPhoneOneCpsDisplay : MonoBehaviour
{
    TextMeshProUGUI oneCps;
    OldPhoneGame oldPhoneGame;

    void Start()
    {
        oneCps = GetComponent<TextMeshProUGUI>();
        oldPhoneGame = FindObjectOfType<OldPhoneGame>();
    }
    void Update()
    {
        oneCps.text = "+" + oldPhoneGame.GetOneCps().ToString() + "/s";
    }
}
