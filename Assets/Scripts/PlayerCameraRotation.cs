using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraRotation : MonoBehaviour
{
    public Transform Myplayer;
    [SerializeField] Vector3 offset;
    // Update is called once per frame
    void Update()
    {

        this.transform.position = Myplayer.position + offset;
    }
}
