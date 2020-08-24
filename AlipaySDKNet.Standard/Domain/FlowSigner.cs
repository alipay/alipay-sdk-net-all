using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FlowSigner Data Structure.
    /// </summary>
    [Serializable]
    public class FlowSigner : AopObject
    {
        /// <summary>
        /// 创建流程时指定的企业唯一标识，仅签署主体为企业时返回
        /// </summary>
        [XmlElement("org_third_party_user_id")]
        public string OrgThirdPartyUserId { get; set; }

        /// <summary>
        /// 签署状态：0-待签, 1-未签, 2-已签 3-待审批 4-拒签
        /// </summary>
        [XmlElement("sign_status")]
        public long SignStatus { get; set; }

        /// <summary>
        /// 签署主体类型：0-个人, 1-企业
        /// </summary>
        [XmlElement("signer_account_type")]
        public long SignerAccountType { get; set; }

        /// <summary>
        /// 创建流程时指定个人唯一标识
        /// </summary>
        [XmlElement("third_party_user_id")]
        public string ThirdPartyUserId { get; set; }
    }
}
