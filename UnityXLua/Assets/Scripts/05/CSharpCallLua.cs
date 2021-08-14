using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class CSharpCallLua : MonoBehaviour {

    private LuaEnv luaeav;
    // Use this for initialization
    void Start()
    {
        luaeav = new LuaEnv();
        //TextAsset luaFile = Resources.Load<TextAsset>("HelloXLua.lua");
        //luaeav.DoString(luaFile.text);

        luaeav.DoString("require 'CSharpCallLua'");

        int a = luaeav.Global.Get<int>("a");
        print(a);

        string name = luaeav.Global.Get<string>("name");
        print(name);

        bool isWin = luaeav.Global.Get<bool>("isWin");
        print(isWin);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
