using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcServiceOrderBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcServiceOrderBindModel : AopObject
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
        /// 选择服务关联的服务ID
        /// </summary>
        [XmlElement("related_service_id")]
        public string RelatedServiceId { get; set; }

        /// <summary>
        /// 选择的服务能力列表
        /// </summary>
        [XmlArray("service_ability_info_list")]
        [XmlArrayItem("service_ability")]
        public List<ServiceAbility> ServiceAbilityInfoList { get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
