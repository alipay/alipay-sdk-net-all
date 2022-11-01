using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyFinleaseSignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoanapplyFinleaseSignQueryModel : AopObject
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        [XmlElement("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 商家ipid
        /// </summary>
        [XmlElement("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
