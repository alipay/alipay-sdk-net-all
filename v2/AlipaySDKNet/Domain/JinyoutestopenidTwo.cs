using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JinyoutestopenidTwo Data Structure.
    /// </summary>
    [Serializable]
    public class JinyoutestopenidTwo : AopObject
    {
        /// <summary>
        /// 无openid,有枚举值，有注意事项
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }

        /// <summary>
        /// 有openid，无枚举值，无注意事项
        /// </summary>
        [XmlElement("b")]
        public string B { get; set; }

        /// <summary>
        /// 有openid，无枚举值，无注意事项,openid有注意事项
        /// </summary>
        [XmlElement("b_open_id")]
        public string BOpenId { get; set; }

        /// <summary>
        /// 复杂类型第二层
        /// </summary>
        [XmlElement("f")]
        public JinyoutestopenidOne F { get; set; }
    }
}
