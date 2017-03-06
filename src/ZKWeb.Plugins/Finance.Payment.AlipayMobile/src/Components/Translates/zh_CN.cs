﻿using System.Collections.Generic;
using ZKWeb.Localize;
using ZKWebStandard.Extensions;
using ZKWebStandard.Ioc;

namespace ZKWeb.Plugins.Finance.Payment.AlipayMobile.src.Components.Translates {
	/// <summary>
	/// 中文翻译
	/// </summary>
	[ExportMany, SingletonReuse]
	public class zh_CN : ITranslateProvider {
		private static HashSet<string> Codes = new HashSet<string>() { "zh-CN" };
		private static Dictionary<string, string> Translates = new Dictionary<string, string>()
		{
			// TODO: 翻译到其他语言
			{ "AlipayMobilePaymentApi", "支付宝移动端支付" },
			{ "Support pay transactions by alipay mobile", "支持在移动端通过支付宝支付交易" },
			{ "AlipayBarCodePay", "支付宝扫码支付" },
			{ "AppId, usually starts with datetime such as 20170306", "AppId, 通常以日期开始例如20170306" }
		};

		public bool CanTranslate(string code) {
			return Codes.Contains(code);
		}

		public string Translate(string text) {
			return Translates.GetOrDefault(text);
		}
	}
}