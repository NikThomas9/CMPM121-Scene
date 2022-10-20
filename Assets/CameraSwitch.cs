using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject cam_1P;
    public GameObject cam_3P;
    public GameObject cam_movement;
    public GameObject cam_ortho;
    
    // Start is called before the first frame update
    void Start()
    {
        cam_1P.SetActive(true);
        cam_3P.SetActive(false);
        cam_movement.SetActive(false);
        cam_ortho.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setRotate()
    {
        cam_1P.SetActive(false);
        cam_3P.SetActive(false);
        cam_movement.SetActive(true);
        cam_ortho.SetActive(false);
    }

    public void set3P()
    {
        cam_1P.SetActive(false);
        cam_3P.SetActive(true);
        cam_movement.SetActive(false);
        cam_ortho.SetActive(false);
    }

    public void set1P()
    {
        cam_1P.SetActive(true);
        cam_3P.SetActive(false);
        cam_movement.SetActive(false);
        cam_ortho.SetActive(false);
    }

    public void setOrtho()
    {
        cam_1P.SetActive(false);
        cam_3P.SetActive(false);
        cam_movement.SetActive(false);
        cam_ortho.SetActive(true);
    }
}
