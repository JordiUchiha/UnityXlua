using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class CallLuaFile : MonoBehaviour {

    private LuaEnv luaeav;
	// Use this for initialization
	void Start () {
        luaeav = new LuaEnv();
        //TextAsset luaFile = Resources.Load<TextAsset>("HelloXLua.lua");
        //luaeav.DoString(luaFile.text);

        luaeav.DoString("require 'HelloXLua'");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
