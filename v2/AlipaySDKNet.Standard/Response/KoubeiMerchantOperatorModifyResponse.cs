using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorModifyResponse.
    /// </summary>
    public class KoubeiMerchantOperatorModifyResponse : AopResponse
    {
        /// <summary>
        /// 操作员ID
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }
    }
}
