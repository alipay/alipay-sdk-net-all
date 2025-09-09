using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHdfaitransferConclusionGenerateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHdfaitransferConclusionGenerateModel : AopObject
    {
        /// <summary>
        /// 交流记录信息
        /// </summary>
        [XmlArray("chat_record_info")]
        [XmlArrayItem("chat_record_info")]
        public List<ChatRecordInfo> ChatRecordInfo { get; set; }

        /// <summary>
        /// 病历信息
        /// </summary>
        [XmlElement("medical_record_info")]
        public MedicalRecordInfo MedicalRecordInfo { get; set; }
    }
}
