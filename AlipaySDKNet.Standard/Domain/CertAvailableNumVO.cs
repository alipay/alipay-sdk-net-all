using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertAvailableNumVO Data Structure.
    /// </summary>
    [Serializable]
    public class CertAvailableNumVO : AopObject
    {
        /// <summary>
        /// 凭证可用点数。
        /// </summary>
        [XmlElement("available_num")]
        public long AvailableNum { get; set; }

        /// <summary>
        /// 凭证模板ID。
        /// </summary>
        [XmlElement("cert_template_id")]
        public string CertTemplateId { get; set; }
    }
}
