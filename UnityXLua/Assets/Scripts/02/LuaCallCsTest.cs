using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class LuaCallCsTest : MonoBehaviour {

    private LuaEnv luaeav;
	// Use this for initialization
	void Start () {
        luaeav = new LuaEnv();
        luaeav.DoString("CS.UnityEngine.Debug.Log('Hello Xlua')");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
