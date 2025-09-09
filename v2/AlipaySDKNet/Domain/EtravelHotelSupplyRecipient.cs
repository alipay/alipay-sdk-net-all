using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EtravelHotelSupplyRecipient Data Structure.
    /// </summary>
    [Serializable]
    public class EtravelHotelSupplyRecipient : AopObject
    {
        /// <summary>
        /// 城市，按照国家邮政规范填写即可。电子发票无需填写。
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 行政区，按照国家邮政规范填写即可。电子发票无需填写。
        /// </summary>
        [XmlElement("dstrict")]
        public string Dstrict { get; set; }

        /// <summary>
        /// 邮箱，电子发票时该字段必须填写
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 收件人，按照国家邮政规范填写即可。电子发票无需填写。
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 电话，按照国家邮政规范填写即可。电子发票无需填写。
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 邮编，按照国家邮政规范填写即可。电子发票无需填写。
        /// </summary>
        [XmlElement("postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// 省份，按照国家邮政规范填写即可。电子发票无需填写。
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 街道，按照国家邮政规范填写即可。电子发票无需填写。
        /// </summary>
        [XmlElement("street")]
        public string Street { get; set; }
    }
}
