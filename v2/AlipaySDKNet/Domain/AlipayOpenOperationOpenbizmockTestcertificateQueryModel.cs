using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockTestcertificateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockTestcertificateQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("hahaha")]
        public string Hahaha { get; set; }

        /// <summary>
        /// ceshi
        /// </summary>
        [XmlElement("keykey")]
        public string Keykey { get; set; }

        /// <summary>
        /// ceshi
        /// </summary>
        [XmlElement("keykey_openid")]
        public string KeykeyOpenid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("lalala")]
        public string Lalala { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
