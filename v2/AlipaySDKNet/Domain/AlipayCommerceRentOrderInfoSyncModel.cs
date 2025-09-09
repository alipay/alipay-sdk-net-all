using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentOrderInfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentOrderInfoSyncModel : AopObject
    {
        /// <summary>
        /// 2088开头的16位纯数字，小程序场景下获取用户ID请参考：用户授权; 其它场景下获取用户ID请参考：网页授权获取用户信息; 其中buyer_id与buyer_open_id不能同时为空
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付宝用户唯一标识
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 交易组件分期单号
        /// </summary>
        [XmlElement("installment_no")]
        public string InstallmentNo { get; set; }

        /// <summary>
        /// 交易组件的业务订单Id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 支付渠道，例如 ALIPAY、WECHAT、OTHER
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 商户同步的租赁支付明细
        /// </summary>
        [XmlArray("rent_pay_info")]
        [XmlArrayItem("rent_pay_info_d_t_o")]
        public List<RentPayInfoDTO> RentPayInfo { get; set; }

        /// <summary>
        /// 支付交易号，pay_channnel=ALIPAY 必填
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
