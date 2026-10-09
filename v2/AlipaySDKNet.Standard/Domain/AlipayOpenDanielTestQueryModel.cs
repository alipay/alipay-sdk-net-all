using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenDanielTestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenDanielTestQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("body_str")]
        public string BodyStr { get; set; }

        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("strig_dtest")]
        public string StrigDtest { get; set; }
    }
}
