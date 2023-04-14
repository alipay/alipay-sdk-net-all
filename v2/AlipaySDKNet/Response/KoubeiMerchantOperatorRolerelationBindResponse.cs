using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorRolerelationBindResponse.
    /// </summary>
    public class KoubeiMerchantOperatorRolerelationBindResponse : AopResponse
    {
        /// <summary>
        /// 操作是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
