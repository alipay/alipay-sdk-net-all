using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IdentityMaterials Data Structure.
    /// </summary>
    [Serializable]
    public class IdentityMaterials : AopObject
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
        /// 申请材料类型 ● DISCHARGE_SUMMARY：出院小结 ● HOSPITALIZATION_INVOICE：住院发票第一联原件 ● HOSPITALIZATION_EXPENSES_TOTAL：住院总费用清单 ● CASE_HISTORY：住院病历 ● MEDICAL_INSURANCE_SETTLEMENT：医保结算单原件 ● OTHER：其他● IDENTITY_FRONT：身份证件正面● IDENTITY_BACK：身份证件反面● ADDRESS：家庭住址● PHONE_NO：联系方式● ANTI_MONEY_LAUNDERING：反洗钱补材● ID_CARD_START_DATE：身份证开始日期● ID_CARD_END_DATE：身份证截止日期● IMAGE：影像件
        /// </summary>
        [XmlElement("material_type")]
        public string MaterialType { get; set; }

        /// <summary>
        /// 申请材料地址
        /// </summary>
        [XmlArray("pic_urls")]
        [XmlArrayItem("string")]
        public List<string> PicUrls { get; set; }
    }
}
