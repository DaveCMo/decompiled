using System;
using UnityEngine;

namespace SwrveUnity.Input
{
	public class NativeInputManager : IInputManager
	{
		private static NativeInputManager instance;

		public static NativeInputManager Instance
		{
			get
			{
				if (NativeInputManager.instance == null)
				{
					NativeInputManager.instance = new NativeInputManager();
				}
				return NativeInputManager.instance;
			}
		}

		private NativeInputManager()
		{
		}

		bool IInputManager.GetMouseButtonUp(int buttonId)
		{
			return !Input.GetMouseButton(buttonId);
		}

		bool IInputManager.GetMouseButtonDown(int buttonId)
		{
			return Input.GetMouseButton(buttonId);
		}

		Vector3 IInputManager.GetMousePosition()
		{
			Vector3 mousePosition = Input.mousePosition;
			mousePosition.y = (float)Screen.height - mousePosition.y;
			return mousePosition;
		}
	}
}
