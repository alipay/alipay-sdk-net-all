using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppCommunityAccessUploadResponse.
    /// </summary>
    public class AlipayEbppCommunityAccessUploadResponse : AopResponse
    {
        /// <summary>
        /// 脱敏后的手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 开门原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 脱敏后的用户名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
