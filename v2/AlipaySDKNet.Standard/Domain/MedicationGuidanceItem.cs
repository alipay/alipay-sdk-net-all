using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicationGuidanceItem Data Structure.
    /// </summary>
    [Serializable]
    public class MedicationGuidanceItem : AopObject
    {
        /// <summary>
        /// 注意事项
        /// </summary>
        [XmlElement("cautions_desc")]
        public string CautionsDesc { get; set; }

        /// <summary>
        /// 药品名称
        /// </summary>
        [XmlElement("drug_name")]
        public string DrugName { get; set; }

        /// <summary>
        /// 用药指导
        /// </summary>
        [XmlElement("drug_specifications")]
        public string DrugSpecifications { get; set; }
    }
}
