using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OfflineLaborPolicyholderAddress Data Structure.
    /// </summary>
    [Serializable]
    public class OfflineLaborPolicyholderAddress : AopObject
    {
        /// <summary>
        /// 投保人的详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 行政区划代码
        /// </summary>
        [XmlElement("address_code")]
        public string AddressCode { get; set; }

        /// <summary>
        /// 区县
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 固定电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        [XmlElement("zip")]
        public string Zip { get; set; }
    }
}
