using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JinyoutestopenidThree Data Structure.
    /// </summary>
    [Serializable]
    public class JinyoutestopenidThree : AopObject
    {
        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }

        /// <summary>
        /// 有openid,无枚举，有注意事项
        /// </summary>
        [XmlElement("b")]
        public string B { get; set; }

        /// <summary>
        /// 有openid,无枚举，有注意事项
        /// </summary>
        [XmlElement("b_open_id")]
        public string BOpenId { get; set; }

        /// <summary>
        /// 复杂参数2
        /// </summary>
        [XmlElement("f")]
        public JinyoutestopenidTwo F { get; set; }
    }
}
