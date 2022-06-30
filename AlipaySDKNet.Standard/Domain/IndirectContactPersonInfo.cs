using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndirectContactPersonInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndirectContactPersonInfo : AopObject
    {
        /// <summary>
        /// 联系人身份证号
        /// </summary>
        [XmlElement("contact_card_no")]
        public string ContactCardNo { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系人手机
        /// </summary>
        [XmlElement("contact_phone_no")]
        public string ContactPhoneNo { get; set; }
    }
}
