using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnterpriseDelegationAuth Data Structure.
    /// </summary>
    [Serializable]
    public class EnterpriseDelegationAuth : AopObject
    {
        /// <summary>
        /// 签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 授权时间
        /// </summary>
        [XmlElement("auth_time")]
        public string AuthTime { get; set; }

        /// <summary>
        /// 授权方ID
        /// </summary>
        [XmlElement("licensor")]
        public string Licensor { get; set; }

        /// <summary>
        /// 授权方名称
        /// </summary>
        [XmlElement("licensor_name")]
        public string LicensorName { get; set; }

        /// <summary>
        /// 授权方ID
        /// </summary>
        [XmlElement("licensor_open_id")]
        public string LicensorOpenId { get; set; }
    }
}
