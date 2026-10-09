using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditbizorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPayafteruseCreditbizorderQueryModel : AopObject
    {
        /// <summary>
        /// 信用服务订单号，out_order_no与credit_biz_order_id至少传一个
        /// </summary>
        [XmlElement("credit_biz_order_id")]
        public string CreditBizOrderId { get; set; }

        /// <summary>
        /// 商户外部单号，out_order_no与credit_biz_order_id至少传一个
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
