using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JohnBundalian
{
    public class EventsManager : MonoBehaviour
    {
        // Thisw will contain ALL OF OUR EVENTS
        // The Delegate which is the "type of event"
        // The Event itself, which gets "announced."

        public delegate void VoidDelegate();

        // Static exists within the script
        public static VoidDelegate OnTeleportEvent;
        public static VoidDelegate OnColourChangeEvent;
        public static VoidDelegate OnTransientBlockActivatorEvent;
        public static VoidDelegate OnRespawning;

    }

}
