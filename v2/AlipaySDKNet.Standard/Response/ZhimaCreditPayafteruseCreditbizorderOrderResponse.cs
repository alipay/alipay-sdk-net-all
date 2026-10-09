using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditbizorderOrderResponse.
    /// </summary>
    public class ZhimaCreditPayafteruseCreditbizorderOrderResponse : AopResponse
    {
        /// <summary>
        /// 信用服务订单号
        /// </summary>
        [XmlElement("credit_biz_order_id")]
        public string CreditBizOrderId { get; set; }

        /// <summary>
        /// 商户传入的外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
