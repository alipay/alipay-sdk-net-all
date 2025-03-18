using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AftersaleAddressInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class AftersaleAddressInfoVO : AopObject
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
        /// 退货联系电话
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 省份，直辖市直接填写简称即可，例如：北京
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 退货联系人姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
