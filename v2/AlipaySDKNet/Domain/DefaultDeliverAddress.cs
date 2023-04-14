using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DefaultDeliverAddress Data Structure.
    /// </summary>
    [Serializable]
    public class DefaultDeliverAddress : AopObject
    {
        /// <summary>
        /// 地址详情
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 地区名
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 城市名
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        [XmlElement("fullname")]
        public string Fullname { get; set; }

        /// <summary>
        /// 收货人手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 省名
        /// </summary>
        [XmlElement("prov")]
        public string Prov { get; set; }
    }
}
