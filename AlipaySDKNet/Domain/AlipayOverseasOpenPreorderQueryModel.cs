using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasOpenPreorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasOpenPreorderQueryModel : AopObject
    {
        /// <summary>
        /// 预缴费单号
        /// </summary>
        [XmlElement("pre_order_id")]
        public string PreOrderId { get; set; }
    }
}
