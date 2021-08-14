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
        IPerson p = luaeav.Global.Get<IPerson>("Person");
        print(p.name);
        p.name = "niu";
        print(p.name);
        p.test();

        p.testArg(1,5); //参数对应

        p.testFunc(10, 1);
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
