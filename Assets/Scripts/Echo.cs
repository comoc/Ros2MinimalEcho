using RosMessageTypes.Std;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Robotics.ROSTCPConnector;

public class Echo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ROSConnection.instance.RegisterPublisher<StringMsg>("from_unity");
        ROSConnection.instance.Subscribe<StringMsg>("to_unity", OnToUnityMsg);
    }

    void OnToUnityMsg(StringMsg msg)
    {
        StringMsg from_unity = new StringMsg();
        from_unity.data = msg.data + ", Unity";
        ROSConnection.instance.Send<StringMsg>("from_unity", from_unity);
        Debug.Log(msg);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
