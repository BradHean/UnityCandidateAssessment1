using UnityEngine;

public class checkoverlap : MonoBehaviour
{
    //for trigger events to be called, at least one object needs a rigidbody
    //I added one to SphereA and all events are fired.
    private void OnTriggerEnter(Collider other)
    {
        print("Started overlap");
    }

    private void OnTriggerExit(Collider other)
    {
        print("Ended overlap");
    }
}
