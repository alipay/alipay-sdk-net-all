using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParticipantExtendParams Data Structure.
    /// </summary>
    [Serializable]
    public class ParticipantExtendParams : AopObject
    {
        /// <summary>
        /// 证件号，participant_id_typ为alipay_user_id可作为补充参数
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }
    }
}
