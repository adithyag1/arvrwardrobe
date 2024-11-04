using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.EventSystems;

public class ARController : MonoBehaviour
{
    public GameObject boyModel;
    public GameObject[] hats;
    public GameObject[] shirts;
    public GameObject[] pants;
    public GameObject[] accessories;
    public GameObject[] fullCostumes;
    public ARRaycastManager raycastManager;

    private GameObject currentBoyModel;
    private GameObject currentHat;
    private GameObject currentShirt;
    private GameObject currentPants;
    private GameObject currentAccessory;
    private GameObject currentFullCostume;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && !IsPointerOverUIObject())
        {
            List<ARRaycastHit> touches = new List<ARRaycastHit>();
            raycastManager.Raycast(Input.GetTouch(0).position, touches, UnityEngine.XR.ARSubsystems.TrackableType.Planes);
            if (touches.Count > 0)
            {
                if (currentBoyModel != null)
                    Destroy(currentBoyModel);

                currentBoyModel = Instantiate(boyModel, touches[0].pose.position, touches[0].pose.rotation);
                currentBoyModel.transform.rotation = Quaternion.Euler(0, 180, 0);
            }
        }

        if (currentBoyModel != null)
        {
            currentBoyModel.transform.LookAt(Camera.main.transform);
            currentBoyModel.transform.rotation = Quaternion.Euler(0, currentBoyModel.transform.rotation.eulerAngles.y, 0);
        }
    }

    public void SwitchHat(int index)
    {
        if (currentFullCostume != null)
            Destroy(currentFullCostume);
        if (currentHat != null)
            Destroy(currentHat);

        if (currentBoyModel != null)
        {
            currentHat = Instantiate(hats[index], currentBoyModel.transform);
        }
    }

    public void SwitchShirt(int index)
    {
        if (currentFullCostume != null)
            Destroy(currentFullCostume);
        if (currentShirt != null)
            Destroy(currentShirt);

        if (currentBoyModel != null)
        {
            currentShirt = Instantiate(shirts[index], currentBoyModel.transform);
        }
    }

    public void SwitchPants(int index)
    {
        if (currentFullCostume != null)
            Destroy(currentFullCostume);
        if (currentPants != null)
            Destroy(currentPants);

        if (currentBoyModel != null)
        {
            currentPants = Instantiate(pants[index], currentBoyModel.transform);
        }
    }

    public void SwitchAccessory(int index)
    {
        if (currentFullCostume != null)
            Destroy(currentFullCostume);
        if (currentAccessory != null)
            Destroy(currentAccessory);

        if (currentBoyModel != null)
        {
            currentAccessory = Instantiate(accessories[index], currentBoyModel.transform);
        }
    }

    public void SwitchFullCostume(int index)
    {
        if (currentFullCostume != null)
            Destroy(currentFullCostume);
        if (currentHat != null)
            Destroy(currentHat);
        if (currentShirt != null)
            Destroy(currentShirt);
        if (currentPants != null)
            Destroy(currentPants);
        if (currentAccessory != null)
            Destroy(currentAccessory);

        if (currentBoyModel != null)
        {
            currentFullCostume = Instantiate(fullCostumes[index], currentBoyModel.transform);
        }
    }

    private bool IsPointerOverUIObject()
    {
        PointerEventData eventData = new PointerEventData(EventSystem.current);
        eventData.position = Input.GetTouch(0).position;
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, results);
        return results.Count > 0;
    }
}
