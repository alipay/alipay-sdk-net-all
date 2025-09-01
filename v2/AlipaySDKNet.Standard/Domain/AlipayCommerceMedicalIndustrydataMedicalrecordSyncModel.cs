using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataMedicalrecordSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIndustrydataMedicalrecordSyncModel : AopObject
    {
        /// <summary>
        /// 1 删除 0 未删除
        /// </summary>
        [XmlElement("delete_flag")]
        public string DeleteFlag { get; set; }

        /// <summary>
        /// 病程id
        /// </summary>
        [XmlElement("medical_record_id")]
        public string MedicalRecordId { get; set; }

        /// <summary>
        /// 1 隐私 0 公开
        /// </summary>
        [XmlElement("private_flag")]
        public string PrivateFlag { get; set; }
    }
}
