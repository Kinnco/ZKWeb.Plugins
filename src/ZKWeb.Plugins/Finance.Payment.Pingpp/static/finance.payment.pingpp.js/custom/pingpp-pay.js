﻿/* Ping++支付功能 */

// 点击切换支付渠道
$(function () {
	var $pay = $(".pingpp-pay");
	var $allChannel = $pay.find(".payment-channels .payment-channel");
	var $channelField = $pay.find("[name='PaymentChannel']");
	var activedClass = "border-themed";

	var setActivedChannel = function ($channel) {
		$allChannel.find(".title").removeClass(activedClass);
		$channel.find(".title").addClass(activedClass);
		$channelField.val($channel.data("value"));
	};

	$allChannel.on("click", function () { setActivedChannel($(this)); });
	setActivedChannel($allChannel.first());
});

// 根据服务器返回的支付凭据发起支付
$(function () {
	var $form = $(".pingpp-pay [name='PingppPayForm']");
	$form.on("success", function (e, charge) {
		// 隐藏提交按钮
		$form.find(".form-actions").hide();
		// 发起支付
		pingpp.createPayment(charge, function (result, err) {
			// 记录返回信息
			console.log(result);
			console.log(err.msg);
			console.log(err.extra);
			// 显示提示并判断是否需要返回结果Url
			var backToResultPage = false;
			if (result == "success") {
				// 只有微信公众账号 wx_pub 支付成功的结果会在这里返回，其他的支付结果都会跳转到 extra 中对应的 URL
				if (charge.channel == "wx_pub") {
					backToResultPage = true;
				}
			} else if (result == "fail") {
				// charge 不正确或者微信公众账号支付失败时会在此处返回
				alert(err.msg);
				backToResultPage = true;
			} else if (result == "cancel") {
				// 微信公众账号支付取消支付
				alert(err.msg);
				backToResultPage = true;
			}
			// 返回结果Url
			if (backToResultPage) {
				var resultUrl = location.href.replace("transaction/pay", "transaction/pay_result");
				location.href = resultUrl;
			}
		});
	});
});
