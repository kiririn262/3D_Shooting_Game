using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private GameObject MainCamera;
    [SerializeField]
    private GameObject[] SubCamera;
    private enum key
    {
        Alpha1,
        Alpha2,
        Alpha3,
        Alpha4,
        Alpha5,
        Alpha6,
        Alpha7,
        Alpha8,
        Alpha9,
        Alpha0
    }
    private key _key;

    void Start()
    {
        foreach (GameObject o in SubCamera)
        {
            o.SetActive(false);
        }
    }
    void Update()
    {
        ChangeCamera(MainCamera,SubCamera);
    }
    private void ChangeCamera(GameObject MainCamera,GameObject[] SubCamera)
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            MainCamera.SetActive(true);
            foreach (GameObject o in SubCamera)
            {
                o.SetActive(false);
            }
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)){
            MainCamera.SetActive(false);
            foreach (GameObject o in SubCamera)
            {
                o.SetActive(false);
            }
            SubCamera[0].SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Alpha3)){
            MainCamera.SetActive(false);
            foreach (GameObject o in SubCamera)
            {
                o.SetActive(false);
            }
            SubCamera[1].SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Alpha4)){
            MainCamera.SetActive(false);
            foreach (GameObject o in SubCamera)
            {
                o.SetActive(false);
            }
            SubCamera[2].SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Alpha5)){
            MainCamera.SetActive(false);
            foreach (GameObject o in SubCamera)
            {
                o.SetActive(false);
            }
            SubCamera[3].SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Alpha6)){
            MainCamera.SetActive(false);
            foreach (GameObject o in SubCamera)
            {
                o.SetActive(false);
            }
            SubCamera[4].SetActive(true);
        }
        // switch(_key)
        // {
        //     case key.Alpha1:
        //         MainCamera.SetActive(true);
        //         foreach (GameObject o in SubCamera)
        //         {
        //             o.SetActive(false);
        //         }
        //         break;
        //     case key.Alpha2:
        //         MainCamera.SetActive(false);
        //         foreach (GameObject o in SubCamera)
        //         {
        //             if(!SubCamera[0] == o)
        //             o.SetActive(false);
        //             else o.SetActive(true);
        //         }
        //         break;
        //     case key.Alpha3:

        //     break;
        //     case key.Alpha4:

        //     break;
        //     case key.Alpha5:

        //     break;
        //     case key.Alpha6:

        //     break;
        //     case key.Alpha7:

        //     break;
        //     case key.Alpha8:

        //     break;
        //     case key.Alpha9:

        //     break;
        //     case key.Alpha0:

        //     break;
        // }
    }
}
