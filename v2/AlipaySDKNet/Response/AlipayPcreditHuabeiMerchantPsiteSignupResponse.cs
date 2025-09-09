using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiMerchantPsiteSignupResponse.
    /// </summary>
    public class AlipayPcreditHuabeiMerchantPsiteSignupResponse : AopResponse
    {
        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 报名记录id
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 报名结果状态
        /// </summary>
        [XmlElement("signup_status")]
        public string SignupStatus { get; set; }
    }
}
