using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PhoneStructVO Data Structure.
    /// </summary>
    [Serializable]
    public class PhoneStructVO : AopObject
    {
        /// <summary>
        /// 电话号码，包含区号+电话号码的座机号码格式，以及手机号码格式
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 1-手机号，2-座机
        /// </summary>
        [XmlElement("phone_type")]
        public string PhoneType { get; set; }
    }
}
