using AAA.OpenAI;
using UnityEngine;

public class Clien : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var chatGPTConnection = new ChatGPTConnection("");
        chatGPTConnection.RequestAsync("{こんにちわ}");
    }
}
