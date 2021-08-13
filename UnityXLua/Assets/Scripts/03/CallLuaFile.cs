using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class CallLuaFile : MonoBehaviour {

    private LuaEnv luaeav;
	// Use this for initialization
	void Start () {
        TextAsset luaFile = Resources.Load<TextAsset>("HelloXLua.lua");
        luaeav = new LuaEnv();
        luaeav.DoString(luaFile.text);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
