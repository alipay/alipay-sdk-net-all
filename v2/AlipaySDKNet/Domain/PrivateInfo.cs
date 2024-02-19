using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrivateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PrivateInfo : AopObject
    {
        /// <summary>
        /// 用户身份证号码
        /// </summary>
        [XmlElement("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 用户手机号码
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }
    }
}
