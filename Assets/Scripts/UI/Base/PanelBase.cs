﻿/*
 * 	@面板基类
 *  @by lck
 *  @2014/04/10
 */
using System.Collections;
using UnityEngine;

public class PanelBase : MonoBehaviour {

	// 图片路径
	public string skinPath;
	// 图片
	public GameObject skin;
	// 层级
	public PanelLayer layer;
	// 面板参数
	public object[] args;

	#region 生命周期
	// 初始化
	public virtual void Init(params object[] args)	
	{
		this.args = args;
	}
	// 开始面板前
	public virtual void OnShowing() {}
	// 显示面板后
	public virtual void OnShowed() {}
	// 帧更新
	public virtual void Update() {}
	// 关闭前
	public virtual void OnClosing() {}
	// 关闭后
	public virtual void OnClosed() {}
	#endregion

	#region 操作
	protected virtual void Close()		
	{
		string name = this.GetType ().ToString ();
		PanelMgr.instance.ClosePanel (name);		// 简单调用PanelMgr.instance.ClosePanel
	}	
	#endregion
}