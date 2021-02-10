using UnityEngine;
using System.Collections;

public class EscMenuExitButton : MonoBehaviour
{
    public void OnButtonPress()
    {
        Debug.Log("Esc-Menu exit Button clicked ");
        Application.Quit();
    }
}