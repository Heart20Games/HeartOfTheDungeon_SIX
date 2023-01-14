using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class YarnCommands : MonoBehaviour
{
    private InMemoryVariableStorage storage;

    // Rooms
    [SerializeField] YarnRooms rooms;


    // Variable Initialization
    private void Start()
    {
        storage = GetComponent<InMemoryVariableStorage>();
        rooms.Initialize();
        Dictionary<string, float> tempFloats = new Dictionary<string, float>();
        Dictionary<string, bool> tempBools = new Dictionary<string, bool>();
        storage.SetAllVariables(tempFloats, rooms.bank, tempBools);
    }

    // Yarn Commands
    [YarnCommand("enter_room")]
    private void EnterRoom(string roomName)
    {
        string sceneName = roomName;
        if (roomName.StartsWith("$"))
        {
            sceneName = rooms.bank[roomName];
        }
        if (SceneUtility.GetBuildIndexByScenePath(sceneName) >= 0)
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogWarning("Scene " + sceneName + " not in build. (Corresponds to room " + roomName + ")");
        }
    }

}
