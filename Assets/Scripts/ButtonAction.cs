﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAction : MonoBehaviour
{
  [SerializeField] Image image;

  public void OnClick()
  {
    image.color = Color.red;
  }
}