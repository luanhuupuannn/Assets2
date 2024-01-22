using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class hp : MonoBehaviour
{
    public Image thanhmau;

    public void capnhatthanhmau(float luongmauhientai, float luongmautoida)
    {
        thanhmau.fillAmount = luongmauhientai / luongmautoida;
    }  
}
