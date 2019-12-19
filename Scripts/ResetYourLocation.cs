using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetYourLocation : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public void TeleportResetPlayer()
    {
        player.transform.position = new Vector3(8.879857f, 0.6f, 8.545884f);
    }
}
