using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ChatOptions
{
    public string name;
    [TextArea(10, 10)] public List<string> Greetings = new List<string>();
    [TextArea(10, 10)] public List<string> Task = new List<string>();
    [TextArea(10, 10)] public List<string> TaskRemind = new List<string>();
    [TextArea(10, 10)] public List<string> Discussion = new List<string>();
}
