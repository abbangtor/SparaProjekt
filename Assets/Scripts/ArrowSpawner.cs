using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ArrowSpawner : MonoBehaviour
{
    public GameObject arrow;
    public GameObject notch;

    private XRGrabInteractable _bow;
    private bool _arrowNotched = false;
    private GameObject _currentArrow = null;

    // Start is called before the first frame update
    void Start()
    {
        _bow = GetComponentInParent<XRGrabInteractable>();
        PullInteraction.PullActionReleased += NotchEmpty;
    }

    private void OnDestroy()
    {
        PullInteraction.PullActionReleased -= NotchEmpty;
    }

    // Update is called once per frame
    void Update()
    {
        if (_bow.isSelected && !_arrowNotched)
        {
            _arrowNotched = true;
            StartCoroutine("DelayedSpawn");
        }
        if (!_bow.isSelected)
        {
            Destroy(_currentArrow);
            NotchEmpty(1f);
        }
    }

    private void NotchEmpty(float value)
    {
        _arrowNotched = false;
        _currentArrow = null;
    }
    IEnumerator DelayedSpawn()
    {
        yield return new WaitForSeconds(1f);
        _currentArrow = Instantiate(arrow, notch.transform);
    }
}
