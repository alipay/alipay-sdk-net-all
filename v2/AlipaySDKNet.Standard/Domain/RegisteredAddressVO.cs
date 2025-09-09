using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RegisteredAddressVO Data Structure.
    /// </summary>
    [Serializable]
    public class RegisteredAddressVO : AopObject
    {
        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city")]
        public AreaInfoVO City { get; set; }

        /// <summary>
        /// 注册地址系统
        /// </summary>
        [XmlElement("custom")]
        public string Custom { get; set; }

        /// <summary>
        /// 区/县
        /// </summary>
        [XmlElement("district")]
        public AreaInfoVO District { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [XmlElement("province")]
        public AreaInfoVO Province { get; set; }
    }
}
