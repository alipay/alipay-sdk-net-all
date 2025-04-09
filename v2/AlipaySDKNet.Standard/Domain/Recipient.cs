using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Recipient Data Structure.
    /// </summary>
    [Serializable]
    public class Recipient : AopObject
    {
        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 按照国家邮政规范填写即可。电子发票无需填写。
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 电子发票时该字段必须填写
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 按照国家邮政规范填写即可。电子发票无需填写。
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 按照国家邮政规范填写即可。电子发票无需填写。
        /// </summary>
        [XmlElement("postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 按照国家邮政规范填写即可。电子发票无需填写。
        /// </summary>
        [XmlElement("street")]
        public string Street { get; set; }
    }
}
