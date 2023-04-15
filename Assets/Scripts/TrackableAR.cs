using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TrackableAR : DefaultObserverEventHandler
{
    private bool marker;
    protected override void OnTrackingFound()
    {
        marker = true;
        base.OnTrackingFound();
    }

    protected override void OnTrackingLost()
    {
        marker = false;
        base.OnTrackingLost();
    }

    public bool GetMarker()
    {
        return marker;
    }
}