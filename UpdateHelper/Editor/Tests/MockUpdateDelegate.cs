
namespace UpdateHelper.Editor.Tests {
    public class MockUpdateDelegate : IUpdateDelegate {
        public event System.Action UpdateCalled = delegate {};
        
        public void Update() {
            UpdateCalled.Invoke();
        }
    }
}