using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
using System.IO;
public class CreateLoader : MonoBehaviour {

    private byte[] MyLoader(ref string filePath)
    {
        string absPath = Application.streamingAssetsPath + "/" + filePath + ".lua.txt";
        return System.Text.Encoding.UTF8.GetBytes(File.ReadAllText(absPath));
    }
	// Use this for initialization
	void Start () {
        LuaEnv luaenv = new LuaEnv();

        luaenv.AddLoader(MyLoader);

        luaenv.DoString("require 'TestDefineLoader'");

        luaenv.Dispose();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
