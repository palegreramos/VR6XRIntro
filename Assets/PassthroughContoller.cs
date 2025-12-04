using UnityEngine;




public class PassthroughContoller : MonoBehaviour
{
    public OVRManager ovrManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (ovrManager == null)
        {
            ovrManager = Object.FindFirstObjectByType<OVRManager>();
        }
    }
    public void EnablePassthrough()     {
        if (ovrManager != null)
        {
            ovrManager.isInsightPassthroughEnabled = true;
        }
    }

    public void DisablePassthrough()
    {
        if (ovrManager != null)
        {
            ovrManager.isInsightPassthroughEnabled = false;
        }
    }
    
 
 
}
