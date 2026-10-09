using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BsContactPersonInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BsContactPersonInfo : AopObject
    {
        /// <summary>
        /// 门店联系人姓名
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 13位联系人手机号
        /// </summary>
        [XmlElement("contact_phone_no")]
        public string ContactPhoneNo { get; set; }
    }
}
