using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeCreditGoodsConfirmResponse.
    /// </summary>
    public class AlipayTradeCreditGoodsConfirmResponse : AopResponse
    {
        /// <summary>
        /// 信用服务订单号。
        /// </summary>
        [XmlElement("credit_biz_order_id")]
        public string CreditBizOrderId { get; set; }

        /// <summary>
        /// 代表信用支付确认收货的时间。
        /// </summary>
        [XmlElement("credit_confirm_receive_goods_time")]
        public string CreditConfirmReceiveGoodsTime { get; set; }
    }
}
