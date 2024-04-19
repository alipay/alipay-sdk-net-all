using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnergyGoodRequest Data Structure.
    /// </summary>
    [Serializable]
    public class EnergyGoodRequest : AopObject
    {
        /// <summary>
        /// 发放的能量
        /// </summary>
        [XmlElement("full_energy")]
        public long FullEnergy { get; set; }

        /// <summary>
        /// item的类型
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("energy_ext_request")]
        public List<EnergyExtRequest> Items { get; set; }

        /// <summary>
        /// item的数量
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }
    }
}
