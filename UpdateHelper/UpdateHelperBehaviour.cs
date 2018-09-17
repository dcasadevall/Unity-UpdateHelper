using System.Collections.Generic;
using UnityEngine;

namespace UpdateHelper {
    /// <summary>
    /// Update helper implementation that uses the monobehaviour's update loop.
    /// Usage:
    /// - Place it in your scene.
    /// - Provide it as an IUpdateHelper via Dependency Injection.
    ///
    /// Implementation Notes:
    /// This implementation is not thread safe.
    /// Do not call RegisterDelegate or UnregisterDelegate outside of the main thread.
    /// For the most part, Unity applications will not be multithreaded, so we would rather keep it simple.
    /// If needed, one can create an UpdateHelper implementation that locks on the
    /// delegates when they are modified / iterated.
    /// </summary>
    public class UpdateHelperBehaviour : MonoBehaviour, IUpdateHelper {
        private readonly HashSet<IUpdateDelegate> _delegates = new HashSet<IUpdateDelegate>();

        public void RegisterDelegate(IUpdateDelegate updateDelegate) {
            _delegates.Add(updateDelegate);
        }

        public void UnregisterDelegate(IUpdateDelegate updateDelegate) {
            _delegates.Remove(updateDelegate);
        }

        public void Update() {
            foreach (IUpdateDelegate updateDelegate in _delegates) {
                updateDelegate.Update();
            }
        }
    }
}
