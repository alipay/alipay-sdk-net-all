using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PhoneNumberItem Data Structure.
    /// </summary>
    [Serializable]
    public class PhoneNumberItem : AopObject
    {
        /// <summary>
        /// 电话号码（下拉选中值，对应任务outboundCaller）
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 用途
        /// </summary>
        [XmlElement("phone_usage")]
        public string PhoneUsage { get; set; }
    }
}
