using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsresourceapiAgentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsresourceapiAgentQueryModel : AopObject
    {
        /// <summary>
        /// 用于查询小二的手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }
    }
}
