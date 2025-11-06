using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarfinMortgageFinancePostInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CarfinMortgageFinancePostInfo : AopObject
    {
        /// <summary>
        /// 收件人地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 收件人地区国标码
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 收件人城市国标码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 收件人手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 收件人邮编
        /// </summary>
        [XmlElement("post_code")]
        public string PostCode { get; set; }

        /// <summary>
        /// 收件人省份国标码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }
    }
}
