using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disabler : MonoBehaviour
{
    public void SetEnable(bool isEnable)
   {
     gameObject.SetActive(!isEnable);
   }
}
