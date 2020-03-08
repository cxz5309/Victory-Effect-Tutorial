using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject BoxConfetti;
    public GameObject ConConfetti;

    public void OnConButttonClick()
    {
        GameObject ob = Instantiate(ConConfetti);
        Destroy(ob, 2.5f);
    }
    public void OnBoxButttonClick()
    {
        GameObject ob = Instantiate(BoxConfetti);
        Destroy(ob, 5f);
    }
}
