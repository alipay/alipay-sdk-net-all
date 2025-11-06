using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ClaimReportApplyIdentityMaterials Data Structure.
    /// </summary>
    [Serializable]
    public class ClaimReportApplyIdentityMaterials : AopObject
    {
        /// <summary>
        /// 补充材料话术
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 材料内容
        /// </summary>
        [XmlElement("material_content")]
        public string MaterialContent { get; set; }

        /// <summary>
        /// 申请材料类型 ● DISCHARGE_SUMMARY：出院小结 ● HOSPITALIZATION_INVOICE：住院发票第一联原件 ● HOSPITALIZATION_EXPENSES_TOTAL：住院总费用清单 ● CASE_HISTORY：住院病历 ● MEDICAL_INSURANCE_SETTLEMENT：医保结算单原件 ● OTHER：其他
        /// </summary>
        [XmlElement("material_type")]
        public string MaterialType { get; set; }

        /// <summary>
        /// 材料地址
        /// </summary>
        [XmlElement("pic_urls")]
        public string PicUrls { get; set; }
    }
}
