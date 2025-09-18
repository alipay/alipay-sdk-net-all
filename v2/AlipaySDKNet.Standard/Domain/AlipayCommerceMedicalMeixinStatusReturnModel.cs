using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMeixinStatusReturnModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMeixinStatusReturnModel : AopObject
    {
        /// <summary>
        /// 案件号
        /// </summary>
        [XmlElement("case_no")]
        public string CaseNo { get; set; }

        /// <summary>
        /// 保司名称
        /// </summary>
        [XmlElement("company_type")]
        public string CompanyType { get; set; }

        /// <summary>
        /// 回传事件类型
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 药品列表
        /// </summary>
        [XmlArray("medicine_list")]
        [XmlArrayItem("medicine_info")]
        public List<MedicineInfo> MedicineList { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 已生成待核销：GENERATED 部分核销：PART_VERIFIED 已核销：VERIFIED
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// user_id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
