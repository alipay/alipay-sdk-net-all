using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotManufacturerUrlflowQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotManufacturerUrlflowQueryModel : AopObject
    {
        /// <summary>
        /// 流水号
        /// </summary>
        [XmlElement("flow_no")]
        public string FlowNo { get; set; }
    }
}
