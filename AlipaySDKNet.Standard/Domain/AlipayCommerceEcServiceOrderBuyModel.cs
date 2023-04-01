using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcServiceOrderBuyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcServiceOrderBuyModel : AopObject
    {
        /// <summary>
        /// 共同账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 订购服务的主体ID
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 订购角色类型
        /// </summary>
        [XmlElement("buyer_role_type")]
        public string BuyerRoleType { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 订购的服务ID
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
