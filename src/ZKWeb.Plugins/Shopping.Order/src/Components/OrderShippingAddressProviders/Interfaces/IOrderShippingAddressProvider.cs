﻿using System;
using System.Collections.Generic;
using ZKWeb.Plugins.Shopping.Order.src.Database;
using ZKWeb.Plugins.Shopping.Order.src.Domain.Entities;

namespace ZKWeb.Plugins.Shopping.Order.src.Components.OrderShippingAddressProviders.Interfaces {
	/// <summary>
	/// 创建订单可使用的收货地址的提供器
	/// </summary>
	public interface IOrderShippingAddressProvider {
		/// <summary>
		/// 获取可使用的收货地址
		/// </summary>
		/// <param name="userId">用户Id</param>
		/// <param name="addresses">收货地址列表</param>
		void GetShippingAddresses(Guid? userId, IList<ShippingAddress> addresses);
	}
}
