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

        //值拷贝 代价比较大 修改字段不会同步到table
        Person p = luaeav.Global.Get<Person>("Person");
        print(p.name);
    }

    // Update is called once per frame
    void Update () {
		
	}

    class Person
    {
        public string name;
        public int age;
    }
}
