using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcChargeBillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcChargeBillQueryModel : AopObject
    {
        /// <summary>
        /// 企业码服务费单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("pay_no")]
        public string PayNo { get; set; }
    }
}
