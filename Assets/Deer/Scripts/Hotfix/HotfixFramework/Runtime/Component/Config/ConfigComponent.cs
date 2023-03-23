﻿// ================================================
//描 述 :  
//作 者 : 杜鑫 
//创建时间 : 2021-07-09 08-18-03  
//修改作者 : 杜鑫 
//修改时间 : 2021-07-09 08-18-03  
//版 本 : 0.1 
// ===============================================

using cfg;
using Deer;
using System;
using UnityEngine;
using UnityGameFramework.Runtime;

[DisallowMultipleComponent]
[AddComponentMenu("Deer/Config")]
public class ConfigComponent : GameFrameworkComponent
{
    private ConfigManager m_ConfigManager;
    public Tables Tables { get; set; }

    protected override void Awake()
    {
        base.Awake();
        m_ConfigManager = gameObject.GetOrAddComponent<ConfigManager>();
    }
    public async void LoadAllUserConfig(LoadConfigCompleteCallback loadConfigCompleteCallback)
    {
        Tables = await m_ConfigManager.LoadAllUserConfig();
        loadConfigCompleteCallback(true);
    }
    /// <summary>
    /// 仅移动读取路径配置版本文件
    /// </summary>
    /// <param name="moveConfigToReadWriteCallback"></param>
    public void MoveOnlyReadPathConfigVersionFile(MoveConfigToReadWriteCallback moveConfigToReadWriteCallback = null)
    {
        m_ConfigManager.AsynLoadOnlyReadPathConfigVersionFile(moveConfigToReadWriteCallback);
    }
}