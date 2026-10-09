using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftNfrBenefitQueryResponse.
    /// </summary>
    public class AnttechNftNfrBenefitQueryResponse : AopResponse
    {
        /// <summary>
        /// VALID（有效）/ INVALID_USED（无效-已使用）/ INVALID_EXPIRED（无效-已过期）
        /// </summary>
        [XmlElement("benefit_status")]
        public string BenefitStatus { get; set; }

        /// <summary>
        /// 已核销时返回 nft_tag 的 gmt_create，未核销返回 null
        /// </summary>
        [XmlElement("verify_time")]
        public string VerifyTime { get; set; }
    }
}
