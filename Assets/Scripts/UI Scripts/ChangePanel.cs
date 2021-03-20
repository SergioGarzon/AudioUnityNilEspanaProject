using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePanel : MonoBehaviour
{
    public GameObject gamePanel;
    public GameObject gamePanel2;

    public void changePanel()
    {
        if(gamePanel != null)
            gamePanel.SetActive(true);

        if(gamePanel2 != null)
            gamePanel2.SetActive(false);

    }


}
