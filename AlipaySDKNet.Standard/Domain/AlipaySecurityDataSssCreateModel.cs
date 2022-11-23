using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityDataSssCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityDataSssCreateModel : AopObject
    {
        /// <summary>
        /// path.数字，无枚举，有注意事项
        /// </summary>
        [XmlElement("a")]
        public long A { get; set; }

        /// <summary>
        /// body,可选，无openid，有枚举值，注意事项
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 有枚举，必须，有openid，有注意事项
        /// </summary>
        [XmlElement("b")]
        public string B { get; set; }

        /// <summary>
        /// 有枚举，必须，有openid，有注意事项
        /// </summary>
        [XmlElement("b_open_id")]
        public string BOpenId { get; set; }

        /// <summary>
        /// 复杂类型
        /// </summary>
        [XmlElement("f")]
        public JinyoutestopenidThree F { get; set; }
    }
}
