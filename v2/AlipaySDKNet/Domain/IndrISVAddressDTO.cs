using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndrISVAddressDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IndrISVAddressDTO : AopObject
    {
        /// <summary>
        /// 长度100，如果为中文，支付宝侧会做英文翻译，翻译后的地址也需要长度小于100，不能包含特殊字符
        /// </summary>
        [XmlElement("address_1")]
        public string Address1 { get; set; }

        /// <summary>
        /// 长度100，如果为中文，支付宝侧会做英文翻译，翻译后的地址也需要长度小于100，不能包含特殊字符
        /// </summary>
        [XmlElement("address_2")]
        public string Address2 { get; set; }

        /// <summary>
        /// 城市名称：英文或者拼音
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 城市code
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 两位国家码
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// 省份名称:英文或者拼音
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }

        /// <summary>
        /// 省份Code
        /// </summary>
        [XmlElement("state_code")]
        public string StateCode { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        [XmlElement("zip_code")]
        public string ZipCode { get; set; }
    }
}
