using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Math : MonoBehaviour
{
    public TMP_InputField input1;
    public TMP_InputField input2;
    public TextMeshProUGUI show;
 

    void Start()
    {
        show.text = "---";
      
    }

    public void sumthen()
    {
  
        float area = float.Parse(input1.text) * float.Parse(input2.text) / 2;
        show.text = area.ToString();

    }




}
