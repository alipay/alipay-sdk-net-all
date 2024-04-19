using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitDeliveryInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitDeliveryInfoDTO : AopObject
    {
        /// <summary>
        /// 券的可用区域
        /// </summary>
        [XmlArray("available_areas")]
        [XmlArrayItem("string")]
        public List<string> AvailableAreas { get; set; }

        /// <summary>
        /// 券的可用店铺
        /// </summary>
        [XmlArray("available_shops")]
        [XmlArrayItem("string")]
        public List<string> AvailableShops { get; set; }

        /// <summary>
        /// 描述是线上还是线下业务
        /// </summary>
        [XmlArray("deliver_scene")]
        [XmlArrayItem("string")]
        public List<string> DeliverScene { get; set; }

        /// <summary>
        /// 用于描述投放的类型，支持 AREA、SHOP
        /// </summary>
        [XmlElement("deliver_type")]
        public string DeliverType { get; set; }
    }
}
