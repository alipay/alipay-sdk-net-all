using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppDeliveryTemplateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppDeliveryTemplateQueryModel : AopObject
    {
        /// <summary>
        /// 履约类型
        /// </summary>
        [XmlElement("delivery_type")]
        public string DeliveryType { get; set; }
    }
}
