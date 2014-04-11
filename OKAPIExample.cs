using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OKAPIExample : OdnoklassnikiWebplayerAPI {
	
	void Start () {
		#if UNITY_WEBPLAYER
		base.LogToConsole("OKAPIExample: I'm OKAPI example. I can call API methods :)");
		Dictionary<string,string> p = new Dictionary<string,string>()
		{
			{"method","users.getCurrentUser"},
			{"fields","last_name,first_name"}
		};
		List<string> permissions = new List<string>()
		{
			"SET_STATUS"
		};
		base.CallApiMethod(p);
		base.JSgetPageInfo();
		base.GetUrlVars();
		//uncomment only one of this methods in one try to try it, becouse using many UI methods at same time is bad
		//base.JSsetWindowSize(100,100);
		//base.JSshowInvite(null, null, "543407152182;382406172993");
		//base.JSshowInvite("Let's play my game", null, null);
		//base.JSshowInvite("Let's play my game", "aaa=bbb", "543407152182;382406172993");
		//base.JSshowPayment("Яблоко", "Это очень вкусно!", "777", 1, null, null, "ok", "true");
		//base.JSshowPermissions(permissions);
		base.Publish("Can I publish?", "I use Unity SDK", null, null);
		#endif
	}

#if UNITY_WEBPLAYER
	protected override void APIMethodCallback(string param){
		base.LogToConsole ("OKAPIExample APICALLBACK: " + param);
	}

	protected override void JSMethodCallback(string param){
		base.LogToConsole ("OKAPIExample JSCALLBACK: " + param);
	}
#endif

}
