using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowFundtradeCreateResponse.
    /// </summary>
    public class AlipayCommerceLogisticsFreightflowFundtradeCreateResponse : AopResponse
    {
        /// <summary>
        /// 业务请求没有失败码返回时必填,同入参中的biz_no
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 订单支付URL,平台可据此生成二维码(Base64格式，使用前先解码)
        /// </summary>
        [XmlElement("order_pay_url")]
        public string OrderPayUrl { get; set; }

        /// <summary>
        /// 业务请求没有失败码返回时必填,状态为UNKNOWN不代表交易失败，需要通过回查确认最终的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 当status=SUCCESS时必选
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
