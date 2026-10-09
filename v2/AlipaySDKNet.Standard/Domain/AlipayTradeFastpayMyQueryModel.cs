using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeFastpayMyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeFastpayMyQueryModel : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 测试描述
        /// </summary>
        [XmlElement("number")]
        public string Number { get; set; }

        /// <summary>
        /// 座机号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
