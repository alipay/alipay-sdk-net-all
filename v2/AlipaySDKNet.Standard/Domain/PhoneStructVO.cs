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
        /// 客服链接地址，必须以alipays开头。用户点击链接后可直接进入客服页面进行咨询
        /// </summary>
        [XmlElement("customer_link")]
        public string CustomerLink { get; set; }

        /// <summary>
        /// 电话号码，包含区号+电话号码的座机号码格式，以及手机号码格式
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 电话类型
        /// </summary>
        [XmlElement("phone_type")]
        public string PhoneType { get; set; }
    }
}
