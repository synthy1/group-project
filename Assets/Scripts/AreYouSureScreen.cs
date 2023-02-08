using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreYouSureScreen : MonoBehaviour
{
    public void AreYouSure()
    {
        gameObject.SetActive(true);
    }

    public void No()
    {
        gameObject.SetActive(false);
    }
}
