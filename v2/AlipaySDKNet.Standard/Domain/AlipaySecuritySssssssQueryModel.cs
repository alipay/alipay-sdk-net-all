using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecuritySssssssQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecuritySssssssQueryModel : AopObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("ddd")]
        public string Ddd { get; set; }

        /// <summary>
        /// 阿法
        /// </summary>
        [XmlElement("x_adfa")]
        public string XAdfa { get; set; }
    }
}
