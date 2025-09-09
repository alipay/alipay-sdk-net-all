using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserSimpleVO Data Structure.
    /// </summary>
    [Serializable]
    public class UserSimpleVO : AopObject
    {
        /// <summary>
        /// 收货人详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 收货人所在城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 收货人所在区县
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 收货人地址纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 收货人地址经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 收货人电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 收货人所在省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
