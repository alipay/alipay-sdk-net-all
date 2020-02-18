using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingFacetofaceTwostageUseResponse.
    /// </summary>
    public class AlipayMarketingFacetofaceTwostageUseResponse : AopResponse
    {
        /// <summary>
        /// 业务扩展数据
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 淘宝会员ID
        /// </summary>
        [XmlElement("havana_id")]
        public string HavanaId { get; set; }

        /// <summary>
        /// otp校验结果
        /// </summary>
        [XmlElement("otp_verify")]
        public string OtpVerify { get; set; }

        /// <summary>
        /// 用户userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
