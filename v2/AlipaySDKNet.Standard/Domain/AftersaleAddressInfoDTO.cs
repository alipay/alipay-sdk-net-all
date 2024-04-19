using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AftersaleAddressInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AftersaleAddressInfoDTO : AopObject
    {
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
        /// 详细地址
        /// </summary>
        [XmlElement("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
