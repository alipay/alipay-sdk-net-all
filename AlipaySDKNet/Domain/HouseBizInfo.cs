using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HouseBizInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HouseBizInfo : AopObject
    {
        /// <summary>
        /// 房龄，单位年
        /// </summary>
        [XmlElement("house_age")]
        public long HouseAge { get; set; }

        /// <summary>
        /// 房产价格 售房类型价格单位（元）；房产均价单位(元每平米)；租房类型单位（元每月）；
        /// </summary>
        [XmlElement("house_price")]
        public long HousePrice { get; set; }

        /// <summary>
        /// 房间面积，单位平方米
        /// </summary>
        [XmlElement("house_size")]
        public long HouseSize { get; set; }

        /// <summary>
        /// 房型
        /// </summary>
        [XmlElement("house_type")]
        public string HouseType { get; set; }

        /// <summary>
        /// 房产首图，base64编码字节流
        /// </summary>
        [XmlElement("image_string")]
        public string ImageString { get; set; }

        /// <summary>
        /// 小程序跳转链接
        /// </summary>
        [XmlElement("page_url")]
        public string PageUrl { get; set; }
    }
}
