using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcContractAuthorizeApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcContractAuthorizeApplyModel : AopObject
    {
        /// <summary>
        /// 共同账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 可通过签约消息获取。配合account_id使用，当填写企业共同账户id时，此字段必填
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 企业申请授权的场景码。枚举值 三方代调用授权：THIRD_PARTY_INVOKE_AUTH
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
