using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportWorldCardscriptQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportWorldCardscriptQueryModel : AopObject
    {
        /// <summary>
        /// 脚本名称
        /// </summary>
        [XmlElement("script_name")]
        public string ScriptName { get; set; }

        /// <summary>
        /// 脚本类型
        /// </summary>
        [XmlElement("script_type")]
        public string ScriptType { get; set; }
    }
}
