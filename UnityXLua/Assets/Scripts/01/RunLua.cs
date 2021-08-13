using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class RunLua : MonoBehaviour {

    private LuaEnv luaenv;
	// Use this for initialization
	void Start () {
        luaenv = new LuaEnv();
        luaenv.DoString("print('Hello Xlua')");
	}

    private void OnDestroy()
    {
        luaenv.Dispose();
    }
}
