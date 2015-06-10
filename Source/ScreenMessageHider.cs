using System;
using UnityEngine;

namespace ScreenMessageHider
{
	[KSPAddon(KSPAddon.Startup.MainMenu, true)]
	public class ScreenMessageHider : MonoBehaviour
	{
		void Start()
		{
			GameEvents.onShowUI.Add (onShowUI);
			GameEvents.onHideUI.Add (onHideUI);
		}
		void onShowUI()
		{
			ScreenMessages sm = GameObject.FindObjectOfType<ScreenMessages> ();
			if (sm != null)
				sm.enabled = true;
		}
		void onHideUI()
		{
			ScreenMessages sm = GameObject.FindObjectOfType<ScreenMessages> ();
			if (sm != null)
				sm.enabled = false;
		}
	}
}