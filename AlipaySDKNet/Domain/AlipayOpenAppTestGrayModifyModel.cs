using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppTestGrayModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppTestGrayModifyModel : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }

        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("b")]
        public string B { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("b_param")]
        public string BParam { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("c")]
        public string C { get; set; }

        /// <summary>
        /// d
        /// </summary>
        [XmlElement("d")]
        public string D { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("e")]
        public string E { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
