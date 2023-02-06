using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public string yarnNode;
    public PlayerCore player;

    public void NotifyPlayerEnteredInteractable()
    {
        player.FoundTalkable(yarnNode);
    }

    public void NotifyPlayerLeftInteractable()
    {
        player.LeftTalkable(yarnNode);
    }
}
