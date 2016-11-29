﻿using System.Collections.Generic;
using ZKWeb.Localize;
using ZKWebStandard.Extensions;
using ZKWebStandard.Ioc;

namespace ZKWeb.Plugins.Shopping.Order.src.Components.Translates {
	/// <summary>
	/// 中文翻译
	/// </summary>
	[ExportMany, SingletonReuse]
	public class zh_CN : ITranslateProvider {
		private static HashSet<string> Codes = new HashSet<string>() { "zh-CN" };
		private static Dictionary<string, string> Translates = new Dictionary<string, string>()
		{
			{ "Order", "订单" },
			{ "OrderManage", "订单管理" },
			{ "Order management for ec site", "商城使用的订单管理功能" },
			{ "Buynow", "立刻购买" },
			{ "AddToCart", "加入购物车" },
			{ "Cart", "购物车" },
			{ "The product you are try to purchase does not exist.", "您尝试购买的商品不存在" },
			{ "The product you are try to purchase does not purchasable.", "您尝试购买的商品目前不允许购买" },
			{ "Order count must larger than 0", "订购数量必须大于0" },
			{ "OrderSettings", "订单设置" },
			{ "BuynowCartProductExpiresDays", "立刻购买的购物车商品的过期天数" },
			{ "NormalCartProductExpiresDays", "一般的购物车商品的过期天数" },
			{ "AutoConfirmOrderAfterDays", "自动确认收货天数" },
			{ "AllowAnonymousVisitorCreateOrder", "允许非会员下单" },
			{ "Create order require user logged in", "创建订单需要用户登录" },
			{ "ProductUnitPrice", "商品单价" },
			{ "ProductTotalPrice", "商品总价" },
			{ "LogisticsCost", "运费" },
			{ "Create order contains multi currency is not supported", "不支持创建包含多种货币的订单" },
			{ "Add product to cart success", "成功添加商品到购物车" },
			{ "Total products", "共有商品" },
			{ "Product total price", "商品总价" },
			{ "Close", "关闭" },
			{ "Checkout >>>", "去结算 >>>" },
			{ "Order product unit price must not be negative", "订单商品的单价必须大于或等于0" },
			{ "Order cost must larger than 0", "订单总价必须大于0" },
			{ "Cart <em>[0]</em> products", "购物车<em>[0]</em>件" },
			{ "<em>[0]</em> Products", "共<em>[0]</em>件商品" },
			{ "Total <em>[0]</em>", "共<em>[0]</em>" },
			{ "Cart is empty", "购物车中还没有商品，赶紧选购吧！" },
			{ "Recently add to cart", "最近加入购物车" },
			{ "Delete Successfully", "删除成功" },
			{ "ShippingAddress", "收货地址" },
			{ "Address/Name/Tel", "地址/姓名/电话" },
			{ "ZipCode", "邮政编码" },
			{ "DetailedAddress", "详细地址" },
			{ "Fullname", "姓名" },
			{ "TelOrMobile", "电话/手机" },
			{ "SubmitOrder", "提交订单" },
			{ "Calculating...", "计算中..." },
			{ "Products total count: <em>0</em>", "商品总数量: <em>0</em>" },
			{ "Products total price: <em>0</em>", "商品总价格: <em>0</em>" },
			{ "Shipping Address:", "收货地址:" },
			{ "Use new address", "使用新地址" },
			{ "Manage shipping address", "管理收货地址" },
			{ "Check this will save or add shipping address", "勾选这里可以保存现有地址或添加新的地址" },
			{ "Save shipping address", "保存收货地址" },
			{ "OrderComment", "订单留言" },
			{ "Logistics:", "物流配送:" },
			{ "Logistics([0]):", "物流配送([0]):" },
			{ "PaymentApi:", "支付接口:" },
			{ "OrderTransaction", "订单交易" },
			{ "Order Comment:", "订单留言:" },
			{ "Please select the products you want to purchase", "请选择您想要购买的商品" },
			{ "Selected logistics is not available for this seller", "该卖家不可使用选择的物流" },
			{ "Please select logistics", "请选择物流" },
			{ "Please select payment api", "请选择支付接口" },
			// TODO: 添加翻译
			{ "AutoCancelOrderAfterDays", "自动取消未付款订单天数" },
			{ "StockReductionMode", "库存减少模式" },
			{ "NoReduction", "不减少" },
			{ "AfterCreateOrder", "创建订单后" },
			{ "AfterOrderPaid", "支付成功后" },
			{ "Order contains product that not exist or deleted", "订单包含不存在或已删除的商品" },
			{ "Insufficient stock of product [{0}]", "商品[{0}]的库存不足" },
			{ "Order contains real products, please select a logistics", "订单包含实体商品，请选择一个物流" },
			{ "Please provide detailed address", "请提供详细的地址" },
			{ "Please provide receiver name", "请提供收货人姓名" },
			{ "Please provide receiver tel or mobile", "请提供收货人电话或手机" },
			{ "To create order please login first", "请先登录再创建订单" },
			{ "Selected logistics is not allowed to use", "选择的物流并不允许使用，请选择其他物流" },
			{ "Selected payment api is not allowed to use", "选择的支付接口并不允许使用，请选择其他支付接口" },
			{ "MergedOrderTransaction", "合并订单交易" },
			{ "Order not found", "订单不存在" },
			{ "Unknow order state: [0]", "未知的订单状态: [0]" },
			{ "Order Checkout", "订单结算" },
			{ "Order successfully created, please continue to pay", "订单创建成功，请付款" },
			{ "Merged transaction successfully created, please continue to pay", "合并交易创建成功，请付款" },
			{ "You have paid successful, please wait for seller delivery", "您已付款成功，请等待卖家发货" },
			{ "You have paid successful, please check following orders", "您已付款成功，请查看以下订单" },
			{ "All goods shipped, please confirm order after receipt all goods", "卖家已发货，请在收到货物后确认收货" },
			{ "Order is successed, thank you for your patronage", "订单交易成功，感谢您的惠顾" },
			{ "Order is canceled", "订单已取消" },
			{ "Order is obsoleted", "订单已作废" },
			{ "OrderSerial", "订单编号" },
			{ "OrderAmount", "订单金额" },
			{ "PaymentAmount", "支付金额" },
			{ "Pay with [0]", "使用[0]支付" },
			{ "Redirecting to order details page......", "正在跳转到订单详情页……" },
			{ "Redirecting to order list page......", "正在跳转到订单列表页……" },
			{ "RemarkFlags", "备注旗帜" },
			{ "Serial/Remark", "编号/备注" },
			{ "Buyer", "买家" },
			{ "Gray", "灰色" },
			{ "Red", "红色" },
			{ "Yellow", "黄色" },
			{ "Green", "绿色" },
			{ "Blue", "蓝色" },
			{ "Purple", "紫色" },
			{ "OrderProducts", "订单商品" },
			{ "Quantity", "数量" },
			{ "ShippedQuantity", "已发货数量" },
			{ "ThisDeliveryQuantity", "本次发货数量" },
			{ "Cost", "金额" },
			{ "TotalCost", "总金额" },
			{ "OrderPricePart", "订单价格组成部分" },
			{ "SellerOrder", "卖家订单" },
			{ "BuyerOrder", "买家订单" },
			{ "WaitingBuyerPay", "等待付款" },
			{ "WaitingSellerDeliveryGoods", "等待发货" },
			{ "WaitingBuyerConfirm", "已发货" },
			{ "OrderSuccess", "交易成功" },
			{ "OrderCancelled", "已取消" },
			{ "OrderInvalid", "已作废" },
			{ "DeliveryRecords", "发货记录" },
			{ "OrderRecords", "订单记录" },
			{ "ReleatedTransactions", "关联交易" },
			{ "OrderComments", "订单留言" },
			{ "Order Informations", "订单信息" },
			{ "You're using secured paid, please confirm transaction on payment platform after received goods",
				"您正在使用担保交易，请在收到货物后到支付平台上确认交易" },
			{ "Buyer is using secured paid, please tell the buyer confirm transaction on payment platform after received goods",
				"买家正在使用担保交易，请通知买家在收到货物后到支付平台上确认交易" },
			{ "Releated transaction contains error: {0}", "关联交易包含错误: {0}" },
			{ "Copy shipping address to clipboard", "复制收货地址" },
			{ "BuyerComment", "买家留言" },
			{ "SellerComment", "卖家留言" },
			{ "More", "更多" },
			{ "OrderLogistics", "物流配送" },
			{ "Order not payable because it's not waiting buyer pay",
				"因为订单状态不是等待付款，不支持付款" },
			{ "Order not payable because no payable releated transactions",
				"因为订单没有可支付的关联交易，不支持付款" },
			{ "Order not cancellable because it's not waiting buyer pay",
				"因为订单状态不是等待付款，不支持取消" },
			{ "Order not cancellable because some releated transaction already paid",
				"因为关联交易已支付，不支持取消" },
			{ "Order can't be confirmed because it's not waiting buyer confirm",
				"因为订单状态不是已发货，不支持确认收货" },
			{ "Order can't edit cost because it's not waiting buyer pay",
				"订单不是等待付款，不能修改价格" },
			{ "Order can't edit cost because some releated transaction paid or realized",
				"关联交易已支付或提交到支付平台，不能修改价格" },
			{ "Order can't edit shipping address because it's not waiting buyer pay or waiting seller send goods",
				"订单不是等待付款或等待发货，不能编辑收货地址" },
			{ "Order can't send goods because it's not waiting seller send goods", "订单不是等待发货，不能进行发货" },
			{ "Order already invalid", "订单已经是作废状态" },
			{ "Order already cancelled", "订单已经是取消状态" },
			{ "Order can't be paid because it's not waiting buyer pay",
				"订单不是等待付款，不能设为已付款" },
			{ "Order can't be paid because not all releated transaction paid",
				"订单的关联交易中有未付款的交易，不能设为已付款"},
			{ "Order can't be shipped because not waiting seller send goods",
				"订单不是等待发货，不能设为已发货" },
			{ "Order can't be shipped because not all goods shipped",
				"订单中有未全部发货的商品，不能设为已发货" },
			{ "Order can't be success because not waiting buyer confirm",
				"订单不是已发货，不能设为交易成功" },
			{ "No payable transaction releated to this order", "没有可以支付的订单交易" },
			{ "PayNow", "立刻付款" },
			{ "CancelOrder", "取消订单" },
			{ "ConfirmOrder", "确认收货" },
			{ "EditCost", "编辑价格" },
			{ "EditShippingAddress", "编辑地址" },
			{ "DeliveryGoods", "发货" },
			{ "ConfirmInsteadOfBuyer", "代确认收货" },
			{ "SetInvalid", "作废" },
			{ "OrderState", "订单状态" },
			{ "OrderActions", "订单操作" },
			{ "OriginalTotalCost", "原始总金额" },
			{ "DeliverySerial", "发货单编号" },
			{ "LogisticsSerial", "快递单编号" },
			{ "DeliveryOperator", "发货人" },
			{ "DeliveryTime", "发货时间" },
			{ "View Transaction", "查看交易" },
			{ "View Delivery", "查看发货单" },
			{ "To delete product please change the quantity to zero, and check transaction amount after modification",
				"删除商品请把数量设为0，并且在修改价格后检查交易的金额" },
			{ "Order total cost", "订单总价" },
			{ "Order not exist", "订单不存在" },
			{ "Order product not exist", "订单商品不存在" },
			{ "Can't delete all products in the order", "不能删除订单中的所有商品" },
			{ "Amount changed by edit order cost, previous value is {0}", "修改订单价格导致金额改变，前值是{0}" },
			{ "Order total cost changed, previous value is {0}", "订单总价已改变，前值是{0}" },
			{ "ManuallyEditPrice", "手动改价" },
			{ "Order shipping address changed, previous value is {0}", "订单收货地址已改变，前值是{0}" },
			{ "Child transactions amount changed by edit order cost, this merge transaction should be aborted",
				"修改订单金额导致子交易金额改变，这个合并交易应当被中止" },
			{ "Child transaction {0} process waiting paying standalone, this merge transaction should be aborted",
				"子交易({0})单独处理等待付款，这个合并交易应当被终止" },
			{ "Child transaction {0} process secured paid standalone, this merge transaction should be aborted",
				"子交易({0})单独处理担保交易已付款，这个合并交易应当被终止" },
			{ "Child transaction {0} process success standalone, this merge transaction should be aborted",
				"子交易({0})单独处理交易成功，这个合并交易应当被终止" },
			{ "Child transaction {0} aborted, this merge transaction should be aborted too",
				"子交易({0})被中止，这个合并交易也应当被中止" },
			{ "Order secured paid from transaction, serial is {0}", "订单通过担保交易支付完成，交易序列号是{0}" },
			{ "Order is paid", "订单已付款" },
			{ "Can't process order paid, reason is {0}", "不能处理订单已付款，原因是{0}" },
			{ "All goods under order is shipped", "订单中的所有商品均已发货" },
			{ "Can't process order shipped, reason is {0}", "不能处理订单已发货，原因是{0}" },
			{ "Order is successed", "订单交易成功" },
			{ "Can't process order successed, reason is {0}", "不能处理订单交易成功，原因是{0}" },
			{ "Order paid from transaction, serial is {0}", "订单通过普通交易支付完成，交易序列号是{0}" },
			{ "Order confirmed from payment platform after secured paid, serial is {0}",
				"通过担保交易支付的订单在交易平台上已确认收货，交易序列号是{0}" },
			{ "Merged Order Checkout", "订单合并结算" },
			{ "Back to order list", "返回订单列表" },
			{ "Order Serial: {0}", "订单编号: {0}" },
			{ "Add comment here then click submit", "添加留言到这里并点击提交按钮" },
			{ "Reason can't be empty", "原因不能为空" },
			{ "Order become invalid, reason is {0}", "订单已作废，原因是{0}" },
			{ "Can't set order invalid, reason is {0}", "不能作废订单，原因是{0}" },
			{ "SetInvalidReason", "作废原因" },
			{ "The reason of set order invalid, must provide", "作废订单的原因，必填" },
			{ "Set order invalid failed, please check order records", "作废订单失败，请检查订单记录" },
			{ "Set order invalid success", "作废订单成功" },
			{ "Order cancelled, reason is {0}", "订单已取消，原因是{0}" },
			{ "Can't cancel order, reason is {0}", "不能取消订单，原因是{0}" },
			{ "CancelReason", "取消原因" },
			{ "The reason of cancel order, must provide", "取消订单的原因，必填" },
			{ "Cancel order failed, please check order records", "取消订单失败，请检查订单记录" },
			{ "Cancel order success", "取消订单成功" },
			{ "Can't delivery product that not exists in order", "不能对不在订单中的商品进行发货" },
			{ "Invalid delivery count", "发货数量不正确" },
			{ "Delivery count can't be larger than unshipped count", "发货数量大于未发货数量" },
			{ "No products to be delivery", "没有要发货的商品" },
			{ "The shipping address is \"{0}\", and buyer want to use logistics \"{1}\"",
				"收货地址是\"{0}\"，且买家希望使用物流\"{1}\"" },
			{ "Order only contains virtual products, if you have something to buyer please use comment",
				"订单仅包含虚拟商品，如果您有什么需要给买家请使用留言" },
			{ "Please provide logistics serial (invoice no)", "请提供物流编号(快递单编号)" },
			{ "Buyer confirm all goods shipped, order should be success",
				"买家已确认收货，订单交易成功" },
			{ "Seller confirm order insetead of buyer, order should be success",
				"卖家在后台代替买家确认收货，订单交易成功" },
			{ "Can't confirm order, reason is {0}", "不能确认收货，原因是{0}" },
			{ "Thank you! Before you confirm receipt", "谢谢惠顾！在确认收货之前请先" },
			{ "Make sure you have received all the goods", "确认您已收到所有的商品" },
			{ "Confirm receipt of the goods in good condition and meet your requirements",
				"确认收到的商品完好无损并满足您的要求" },
			{ "If you are using a secured transaction payment, you will also need to go to the payment platform (such as Alipay) to confirm receipt",
				"如果您使用的是担保交易支付，您还需要到支付平台(例如支付宝)上确认收货" },
			{ "Thank you for your presence, welcome to buy our products again!",
				"感谢您的光临，欢迎再次购买我们的商品！" },
			{ "You are trying to confirm the goods receipt instead of the buyer, please confirm before submitting",
				"您正在尝试代替买家确认收货，请在提交前先确认" },
			{ "Does the buyer not acknowledge receipt within the specified time?",
				"买家是否在规定的时间内没有确认收货？" },
			{ "You can also enable automatically confirm receipt feature form the order settings",
				"您还可以在订单设置中启用自动确认收货的功能" },
			{ "Confirm order failed, please check order records",
				"确认收货失败，请检查订单记录" },
			{ "Confirm order success", "确认收货成功" },
			{ "Auto confirm order after {0} days", "在经过{0}天后仍未确认收货，自动确认收货" },
			{ "Auto cancel order after {0} days unpaid", "在经过{0}天后仍未付款，自动取消订单" },
		};

		public bool CanTranslate(string code) {
			return Codes.Contains(code);
		}

		public string Translate(string text) {
			return Translates.GetOrDefault(text);
		}
	}
}
