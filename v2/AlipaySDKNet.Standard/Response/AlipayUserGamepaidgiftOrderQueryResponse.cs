using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserGamepaidgiftOrderQueryResponse.
    /// </summary>
    public class AlipayUserGamepaidgiftOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 该笔订单用户的订单金额 单位：分
        /// </summary>
        [XmlElement("bill_money")]
        public long BillMoney { get; set; }

        /// <summary>
        /// 游戏商家在平台配置的礼包唯一id
        /// </summary>
        [XmlElement("paid_gift_id")]
        public string PaidGiftId { get; set; }

        /// <summary>
        /// 该笔订单的支付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 游戏平台的唯一订单号
        /// </summary>
        [XmlElement("platform_order_id")]
        public string PlatformOrderId { get; set; }

        /// <summary>
        /// 该笔订单用户购买的礼包数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 该笔订单的退款时间，如果订单状态是退款则返回
        /// </summary>
        [XmlElement("refund_time")]
        public string RefundTime { get; set; }

        /// <summary>
        /// 用户在充值页面填写的角色ID，对应游戏内角色ID
        /// </summary>
        [XmlElement("role_id")]
        public string RoleId { get; set; }

        /// <summary>
        /// 用户充值的区服id，可选
        /// </summary>
        [XmlElement("server_id")]
        public string ServerId { get; set; }

        /// <summary>
        /// CP开发者查询到这几种状态的处理逻辑: success: 订单成功, 正常推进道具发放流程 closed: 订单已关闭, 推进开发者本地订单状态等流程refunded: 订单已退款, 推进开发者本地订单状态等流程 processing: 中间状态, 需要开发者持续轮询, 直到获得明确状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
