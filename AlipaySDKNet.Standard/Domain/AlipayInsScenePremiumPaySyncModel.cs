using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsScenePremiumPaySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsScenePremiumPaySyncModel : AopObject
    {
        /// <summary>
        /// 外部订单id
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 保费打款信息
        /// </summary>
        [XmlElement("premium_payment")]
        public PremiumPaymentDTO PremiumPayment { get; set; }
    }
}
