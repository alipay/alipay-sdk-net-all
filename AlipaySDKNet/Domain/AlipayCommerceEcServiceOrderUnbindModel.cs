using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcServiceOrderUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcServiceOrderUnbindModel : AopObject
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
        /// 订购主体Id
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 服务选择关联的服务ID
        /// </summary>
        [XmlElement("related_service_id")]
        public string RelatedServiceId { get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
