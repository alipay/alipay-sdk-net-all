using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcApprovalConfigModifyResponse.
    /// </summary>
    public class AlipayCommerceEcApprovalConfigModifyResponse : AopResponse
    {
        /// <summary>
        /// 配置ID
        /// </summary>
        [XmlElement("config_id")]
        public string ConfigId { get; set; }
    }
}
