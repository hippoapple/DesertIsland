using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ManCamera : MonoBehaviour
{
    void Awake()
    {
        XRDevice.DisableAutoXRCameraTracking(GetComponent<Camera>(), true);
    }
}
