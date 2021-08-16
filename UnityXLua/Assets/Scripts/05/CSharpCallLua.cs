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

        //映射到 Dictionary List  只映射table中键值对
        Dictionary<string, object> dict = luaeav.Global.Get<Dictionary<string, object>>("Person");

        foreach(var v in dict)
        {
            print(v.Key+v.Value);
        }

        //映射到List 只映射table中的值
        List<object> list = luaeav.Global.Get<List<object>>("Person");
        foreach(var v in list)
        {
            print(v);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}

    [CSharpCallLua]
    public interface IPerson
    {
        string name { get; set; }
        int age { get; set; }

        void test();

        void testArg(int a,int b);

        void testFunc(int a, int b);
    }
}
