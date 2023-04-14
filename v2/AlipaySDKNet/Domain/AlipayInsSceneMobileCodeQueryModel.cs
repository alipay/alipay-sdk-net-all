using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneMobileCodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneMobileCodeQueryModel : AopObject
    {
        /// <summary>
        /// 请求渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 激活码值
        /// </summary>
        [XmlElement("code_value")]
        public string CodeValue { get; set; }
    }
}
