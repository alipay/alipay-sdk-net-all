using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinSaasAgreementQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinSaasAgreementQueryModel : AopObject
    {
        /// <summary>
        /// 外部业务平台会员ID
        /// </summary>
        [XmlElement("out_member_id")]
        public ReferenceId OutMemberId { get; set; }

        /// <summary>
        /// 会员所属业务平台在智能科技的会员ID
        /// </summary>
        [XmlElement("platform_member_id")]
        public string PlatformMemberId { get; set; }
    }
}
