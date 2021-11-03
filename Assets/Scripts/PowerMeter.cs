using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerMeter : MonoBehaviour
{
    public Image powerBar;
    public void setPower(float powerPercent) {
        powerBar.fillAmount = powerPercent / 100f;
    }
}
