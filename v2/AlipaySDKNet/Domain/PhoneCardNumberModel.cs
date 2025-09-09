using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PhoneCardNumberModel Data Structure.
    /// </summary>
    [Serializable]
    public class PhoneCardNumberModel : AopObject
    {
        /// <summary>
        /// 手机号校验码
        /// </summary>
        [XmlElement("check_code")]
        public string CheckCode { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }
    }
}
