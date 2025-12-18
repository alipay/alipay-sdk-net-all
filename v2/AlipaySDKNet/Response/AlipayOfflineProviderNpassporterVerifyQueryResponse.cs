using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderNpassporterVerifyQueryResponse.
    /// </summary>
    public class AlipayOfflineProviderNpassporterVerifyQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 是否核身成功
        /// </summary>
        [XmlElement("verified")]
        public bool Verified { get; set; }
    }
}
