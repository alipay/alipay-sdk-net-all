using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcApprovalConfigQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcApprovalConfigQueryModel : AopObject
    {
        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 支付类型
        /// </summary>
        [XmlElement("payment_type")]
        public string PaymentType { get; set; }

        /// <summary>
        /// 一级场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 二级场景
        /// </summary>
        [XmlElement("scene_sub_category")]
        public string SceneSubCategory { get; set; }
    }
}
