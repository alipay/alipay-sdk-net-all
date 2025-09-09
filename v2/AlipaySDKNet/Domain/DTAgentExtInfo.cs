using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DTAgentExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DTAgentExtInfo : AopObject
    {
        /// <summary>
        /// 参数名称
        /// </summary>
        [XmlElement("param_key")]
        public string ParamKey { get; set; }

        /// <summary>
        /// 参数值
        /// </summary>
        [XmlElement("param_value")]
        public string ParamValue { get; set; }
    }
}
