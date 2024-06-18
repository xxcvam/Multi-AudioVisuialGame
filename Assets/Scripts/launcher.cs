using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class launcher : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();

    }
    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        Debug.Log("连接成功");
    }

}
