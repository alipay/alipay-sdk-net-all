using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpecInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SpecInfo : AopObject
    {
        /// <summary>
        /// 车型ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 最高价格
        /// </summary>
        [XmlElement("max_price")]
        public string MaxPrice { get; set; }

        /// <summary>
        /// 最低价元
        /// </summary>
        [XmlElement("min_price")]
        public string MinPrice { get; set; }

        /// <summary>
        /// 车型名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 车系动力信息
        /// </summary>
        [XmlElement("power_info")]
        public string PowerInfo { get; set; }

        /// <summary>
        /// 车型价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }
    }
}
