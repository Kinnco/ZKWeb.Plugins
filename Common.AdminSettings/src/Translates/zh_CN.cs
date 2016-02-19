﻿using DryIocAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZKWeb.Localize.Interfaces;
using ZKWeb.Utils.Extensions;

namespace ZKWeb.Plugins.Common.AdminSettings.src.Translates {
	/// <summary>
	/// 中文翻译
	/// </summary>
	[ExportMany, SingletonReuse]
	public class zh_CN : ITranslateProvider {
		private static HashSet<string> Codes = new HashSet<string>() { "zh-CN" };
		private static Dictionary<string, string> Translates = new Dictionary<string, string>()
		{
			{ "AdminSettings", "后台设置" },
			{ "Centralized management for admin settings", "提供对后台设置的集中管理" },
			{ "Settings", "设置" },
			{ "BaseSettings", "基本设置" },
			{ "WebsiteSettings", "网站设置" },
			{ "LocaleSettings", "语言设置" },
			{ "Please click the option you want to change on sidebar", "请在侧边栏中选择您想要修改的设置" },
			{ "WebsiteName", "网站名称" },
			{ "DocumentTitleFormat", "标题格式" },
			{ "Default is {title} - {websiteName}", "默认是{title} - {websiteName}"},
			{ "CopyrightText", "版权信息" },
			{ "DefaultLanguage", "默认语言" },
			{ "DefaultTimezone", "默认时区" },
			{ "AllowDetectLanguageFromBrowser", "使用浏览器指定的语言" },
			{ "ar-DZ", "阿拉伯语" },
			{ "zh-CN", "中文" },
			{ "cs-CZ", "捷克语" },
			{ "en-US", "英语" },
			{ "fr-FR", "法语" },
			{ "de-DE", "德语" },
			{ "el-GR", "希腊语" },
			{ "it-IT", "意大利语" },
			{ "ja-JP", "日语" },
			{ "ko-KR", "韩语" },
			{ "pl-PL", "波兰语" },
			{ "ru-RU", "俄语" },
			{ "es-ES", "西班牙语" },
			{ "th-TH", "泰语" },
			{ "zh-TW", "繁体中文" }
		};

		public bool CanTranslate(string code) {
			return Codes.Contains(code);
		}

		public string Translate(string text) {
			return Translates.GetOrDefault(text);
		}
	}
}