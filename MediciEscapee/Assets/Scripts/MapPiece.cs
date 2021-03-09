using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPiece : MonoBehaviour
{
    public int index;

    private void OnDestroy()
    {
        QRcord.instance.FindQRCord(index);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
