using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentHouseEquipmentVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentHouseEquipmentVO : AopObject
    {
        /// <summary>
        /// 是否自定义
        /// </summary>
        [XmlElement("customize")]
        public bool Customize { get; set; }

        /// <summary>
        /// 房屋家具名称
        /// </summary>
        [XmlElement("equipment")]
        public string Equipment { get; set; }

        /// <summary>
        /// 数量（单位：个）
        /// </summary>
        [XmlElement("size")]
        public long Size { get; set; }
    }
}
