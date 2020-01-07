using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantActivityModifyResponse.
    /// </summary>
    public class ZhimaMerchantActivityModifyResponse : AopResponse
    {
        /// <summary>
        /// 芝麻活动号
        /// </summary>
        [XmlElement("activity_no")]
        public string ActivityNo { get; set; }
    }
}
