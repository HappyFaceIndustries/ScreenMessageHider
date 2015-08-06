using System;
using UnityEngine;

namespace ScreenMessageHider
{
	[KSPAddon(KSPAddon.Startup.Instantly, false)]
	public class ScreenMessageHider : MonoBehaviour
	{
		void Start()
		{
			GameEvents.onHideUI.Add (OnHideUI);
			GameEvents.onShowUI.Add (OnShowUI);
		}

		/*
		 *  Seriously Squad, why is this not stock?
		 */

		static ScreenMessages messages;
		void OnHideUI()
		{
			if(messages == null)
				messages = UnityEngine.Object.FindObjectOfType<ScreenMessages> ();
			if (messages != null)
				messages.enabled = false;
		}
		void OnShowUI()
		{
			if(messages == null)
				messages = UnityEngine.Object.FindObjectOfType<ScreenMessages> ();
			if (messages != null)
				messages.enabled = true;
		}
	}
}

