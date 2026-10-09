using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneCommonPolicyCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneCommonPolicyCancelModel : AopObject
    {
        /// <summary>
        /// 保单对应的业务id，例如电商业务的订单id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 预下单id
        /// </summary>
        [XmlElement("pre_order_id")]
        public string PreOrderId { get; set; }
    }
}
