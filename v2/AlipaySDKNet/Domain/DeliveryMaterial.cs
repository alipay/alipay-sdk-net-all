using System;
using System.Xml.Serialization;
using System.Collections.Generic;

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

        /// <summary>
        /// 素材ID，通过alipay.marketing.material.create接口提供的素材组
        /// </summary>
        [XmlArray("material_id_list")]
        [XmlArrayItem("string")]
        public List<string> MaterialIdList { get; set; }
    }
}
