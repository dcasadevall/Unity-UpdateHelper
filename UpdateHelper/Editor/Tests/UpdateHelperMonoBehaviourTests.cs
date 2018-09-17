using NUnit.Framework;
using UnityEngine;

namespace UpdateHelper.Editor.Tests {
	public class UpdateHelperMonoBehaviourTests : MonoBehaviour {
		[TestCase]
		public void TestRegisterUpdateDelegate_UpdateCalled_DelegateReceivesCall() {
			MockUpdateDelegate mockUpdateDelegate = new MockUpdateDelegate();
			bool delegateMethodCalled = false;
			mockUpdateDelegate.UpdateCalled += () => delegateMethodCalled = true;
			
			UpdateHelperBehaviour updateHelperBehaviour = GameObject.CreatePrimitive(PrimitiveType.Cube)
			                                                   .AddComponent<UpdateHelperBehaviour>();
			updateHelperBehaviour.RegisterDelegate(mockUpdateDelegate);
			updateHelperBehaviour.Update();
			
			Assert.True(delegateMethodCalled, "Update delegate not called.");
		}
		
		[TestCase]
		public void TestUnregisterUpdateDelegate_UpdateCalled_DelegateDoesNotReceiveCall() {
			MockUpdateDelegate mockUpdateDelegate = new MockUpdateDelegate();
			bool delegateMethodCalled = false;
			mockUpdateDelegate.UpdateCalled += () => delegateMethodCalled = true;
			
			UpdateHelperBehaviour updateHelperBehaviour = GameObject.CreatePrimitive(PrimitiveType.Cube)
			                                                   .AddComponent<UpdateHelperBehaviour>();
			updateHelperBehaviour.RegisterDelegate(mockUpdateDelegate);
			updateHelperBehaviour.UnregisterDelegate(mockUpdateDelegate);
			updateHelperBehaviour.Update();
			
			Assert.False(delegateMethodCalled, "Update delegate called after Unregister.");
		}
	}
}
