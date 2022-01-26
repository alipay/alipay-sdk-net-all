using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryMaterial Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryMaterial : AopObject
    {
        /// <summary>
        /// 单素材对象
        /// </summary>
        [XmlElement("delivery_single_material")]
        public DeliverySingleMaterial DeliverySingleMaterial { get; set; }
    }
}
