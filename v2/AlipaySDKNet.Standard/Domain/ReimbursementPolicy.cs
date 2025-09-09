using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReimbursementPolicy Data Structure.
    /// </summary>
    [Serializable]
    public class ReimbursementPolicy : AopObject
    {
        /// <summary>
        /// 航段编号（-1为打包说明）
        /// </summary>
        [XmlElement("airline_no")]
        public string AirlineNo { get; set; }

        /// <summary>
        /// 文字描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 1：行程单 2：发票
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
