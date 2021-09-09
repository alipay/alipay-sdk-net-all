using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectSupplementCreateResponse.
    /// </summary>
    public class AntMerchantExpandIndirectSupplementCreateResponse : AopResponse
    {
        /// <summary>
        /// 补录是否成功，TRUE成功，不会返回FALSE，补录异常会抛错误码
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
