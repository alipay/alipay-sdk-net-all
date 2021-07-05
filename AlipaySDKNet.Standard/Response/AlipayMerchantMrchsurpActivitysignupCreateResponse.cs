using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantMrchsurpActivitysignupCreateResponse.
    /// </summary>
    public class AlipayMerchantMrchsurpActivitysignupCreateResponse : AopResponse
    {
        /// <summary>
        /// 报名成功后返回报名记录ID，报名失败无该字段
        /// </summary>
        [XmlElement("signup_record_id")]
        public string SignupRecordId { get; set; }
    }
}
