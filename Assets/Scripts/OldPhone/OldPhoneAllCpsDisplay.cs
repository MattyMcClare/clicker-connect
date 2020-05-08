using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OldPhoneAllCpsDisplay : MonoBehaviour
{
    TextMeshProUGUI allCps;
    OldPhoneGame oldPhoneGame;

    void Start()
    {
        allCps = GetComponent<TextMeshProUGUI>();
        oldPhoneGame = FindObjectOfType<OldPhoneGame>();
    }
    void Update()
    {
        allCps.text = oldPhoneGame.GetAllCps().ToString() + "/s";
    }
}
