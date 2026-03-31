using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEngineeringInfrastructureFortuneEntityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEngineeringInfrastructureFortuneEntityQueryModel : AopObject
    {
        /// <summary>
        /// 自然语言文本
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
