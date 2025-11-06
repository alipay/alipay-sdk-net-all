using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// YxContactInfo Data Structure.
    /// </summary>
    [Serializable]
    public class YxContactInfo : AopObject
    {
        /// <summary>
        /// 联系人姓名
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 数据的ID
        /// </summary>
        [XmlElement("data_id")]
        public long DataId { get; set; }

        /// <summary>
        /// 是否当前客户的默认联系人，N否，Y是
        /// </summary>
        [XmlElement("default_contact")]
        public string DefaultContact { get; set; }

        /// <summary>
        /// 手机号或电话号码
        /// </summary>
        [XmlElement("mobile_phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 联系人职务
        /// </summary>
        [XmlElement("position")]
        public string Position { get; set; }
    }
}
