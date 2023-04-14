using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainArUnsignResponse.
    /// </summary>
    public class MybankCreditSupplychainArUnsignResponse : AopResponse
    {
        /// <summary>
        /// 解约结果：true/false
        /// </summary>
        [XmlElement("invalid_result")]
        public bool InvalidResult { get; set; }
    }
}
