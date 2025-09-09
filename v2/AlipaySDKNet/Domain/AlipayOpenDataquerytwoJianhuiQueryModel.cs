using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenDataquerytwoJianhuiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenDataquerytwoJianhuiQueryModel : AopObject
    {
        /// <summary>
        /// 复杂类型测试1
        /// </summary>
        [XmlElement("fzcsone")]
        public FDataJianTestOne Fzcsone { get; set; }

        /// <summary>
        /// 测试一
        /// </summary>
        [XmlElement("testone")]
        public string Testone { get; set; }
    }
}
