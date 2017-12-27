using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using admob;
public class AdManager : MonoBehaviour {

	// Use this for initialization
	public static AdManager Instance{set;get;}

	public void Start()
	{	
		Instance = this;
		DontDestroyOnLoad (gameObject);
		#if UNITY_EDITOR
		#elif UNITY_ANDROID
		Admob.Instance ().initAdmob ("ca-app-pub-7700781158729760/7249099599","ca-app-pub-7700781158729760/4978159471");
		Admob.Instance ().loadInterstitial ();	
		#endif
		}

	public void ShowBanner()
	{#if UNITY_EDITOR
		#elif UNITY_ANDROID

		Admob.Instance ().showBannerRelative (AdSize.Banner, AdPosition.TOP_CENTER, 5);
		#endif
		}

	public void ShowVideo()
	{#if UNITY_EDITOR
		#elif UNITY_ANDROID

		if (Admob.Instance ().isInterstitialReady ()) {
			Admob.Instance ().showInterstitial ();

		}
		#endif
	}
		
}