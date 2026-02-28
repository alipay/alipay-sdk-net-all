using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceTpaeventSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceTpaeventSyncModel : AopObject
    {
        /// <summary>
        /// 码值
        /// </summary>
        [XmlElement("code_value")]
        public string CodeValue { get; set; }

        /// <summary>
        /// 事件动作
        /// </summary>
        [XmlElement("event_action")]
        public string EventAction { get; set; }

        /// <summary>
        /// 医院编码
        /// </summary>
        [XmlElement("hospital_code")]
        public string HospitalCode { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 个单号
        /// </summary>
        [XmlElement("individual_policy_no")]
        public string IndividualPolicyNo { get; set; }

        /// <summary>
        /// ?付宝?户的唯?ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 机构编号
        /// </summary>
        [XmlElement("outlet_code")]
        public string OutletCode { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        [XmlElement("outlet_name")]
        public string OutletName { get; set; }

        /// <summary>
        /// 网点类型
        /// </summary>
        [XmlElement("outlet_type")]
        public string OutletType { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// TPA编号
        /// </summary>
        [XmlElement("tpa_id")]
        public string TpaId { get; set; }

        /// <summary>
        /// ?付宝?户的唯?ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 就诊日期 
        /// </summary>
        [XmlElement("visit_date")]
        public string VisitDate { get; set; }
    }
}
