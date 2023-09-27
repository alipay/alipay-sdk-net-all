using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinSaasAccountUnbindResponse.
    /// </summary>
    public class AnttechBlockchainDefinSaasAccountUnbindResponse : AopResponse
    {
        /// <summary>
        /// 操作结果 SUCCESS(成功);FAIL(失败);
        /// </summary>
        [XmlElement("op_status")]
        public string OpStatus { get; set; }

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
