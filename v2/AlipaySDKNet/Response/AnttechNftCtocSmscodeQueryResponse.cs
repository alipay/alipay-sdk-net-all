using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftCtocSmscodeQueryResponse.
    /// </summary>
    public class AnttechNftCtocSmscodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 验证码
        /// </summary>
        [XmlElement("sms_code")]
        public string SmsCode { get; set; }
    }
}
