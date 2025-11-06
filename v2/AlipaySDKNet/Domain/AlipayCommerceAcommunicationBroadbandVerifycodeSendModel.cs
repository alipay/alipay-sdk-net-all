using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationBroadbandVerifycodeSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationBroadbandVerifycodeSendModel : AopObject
    {
        /// <summary>
        /// 宽带办理联系电话
        /// </summary>
        [XmlElement("contact_phone_number")]
        public string ContactPhoneNumber { get; set; }

        /// <summary>
        /// 区分具体分省运营商
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
