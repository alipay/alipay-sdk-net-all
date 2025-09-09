using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandAeactivityPlatformQueryResponse.
    /// </summary>
    public class AntMerchantExpandAeactivityPlatformQueryResponse : AopResponse
    {
        /// <summary>
        /// 代表门店报名的状态
        /// </summary>
        [XmlElement("sign_up_status")]
        public string SignUpStatus { get; set; }
    }
}
