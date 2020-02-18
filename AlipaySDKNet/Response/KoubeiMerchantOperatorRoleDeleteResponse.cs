using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorRoleDeleteResponse.
    /// </summary>
    public class KoubeiMerchantOperatorRoleDeleteResponse : AopResponse
    {
        /// <summary>
        /// 删除处理结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
