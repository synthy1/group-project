using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Objectives : MonoBehaviour
{
    public Bed Bedbool;
    public TextMeshProUGUI obj1;
    public TextMeshProUGUI obj2;
    // Start is called before the first frame update
    void Start()
    {
        obj1.enabled = true;
        obj2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Bedbool.pillsTaken == true)
        {
            obj2.fontStyle = FontStyles.Strikethrough;
        }
    }
}
