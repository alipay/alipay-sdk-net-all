using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessParamDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessParamDTO : AopObject
    {
        /// <summary>
        /// 授权协议号，可选。如果已经有有效的授权协议并提供时，会不会创建新的授权协议信息。
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("contact_phone_number")]
        public string ContactPhoneNumber { get; set; }
    }
}
