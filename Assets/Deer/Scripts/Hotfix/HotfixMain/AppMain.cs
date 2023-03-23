// ================================================
//描 述:
//作 者:杜鑫
//创建时间:2022-06-07 00-14-19
//修改作者:杜鑫
//修改时间:2022-06-07 00-14-19
//版 本:0.1 
// ===============================================
using System.Collections;
using System.Collections.Generic;
using Main.Runtime;
using UnityEngine;

/// <summary>
/// Please modify the description.
/// </summary>
public static class AppMain 
{
    /// <summary>
    /// 热更程序入口
    /// </summary>
    /// <param name="objects">全部热更程序集</param>
    public static void Entrance(object[] objects) 
    {
        //打开进度条显示
        GameEntry.UI.DeerUIInitRootForm().OnOpenLoadingForm(true);
        GameEntry.Entrance(objects);
    }
}
