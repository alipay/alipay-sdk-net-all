using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceTpawhiteuserSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceTpawhiteuserSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝给出固定值，见文档
        /// </summary>
        [XmlElement("data_encryption_type")]
        public string DataEncryptionType { get; set; }

        /// <summary>
        /// 主体id
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 支付宝给出固定值，见文档
        /// </summary>
        [XmlElement("entity_type")]
        public string EntityType { get; set; }

        /// <summary>
        /// 扩展信息，业务交互需要
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("insured_list")]
        [XmlArrayItem("insured_info")]
        public List<InsuredInfo> InsuredList { get; set; }

        /// <summary>
        /// 支付宝给出固定值，见文档
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
