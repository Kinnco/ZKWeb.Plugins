﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZKWeb.Plugins.Common.Base.src {
	/// <summary>
	/// 从模型构建表单的构建器，支持多标签
	/// </summary>
	public abstract class TabModelFormBuilder :  ModelFormBuilder {
		/// <summary>
		/// 初始化
		/// </summary>
		public TabModelFormBuilder() : base(new TabFormBuilder()) { }
	}
}
