using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcApprovalModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcApprovalModifyModel : AopObject
    {
        /// <summary>
        /// 申请结束时间
        /// </summary>
        [XmlElement("apply_finish_time")]
        public string ApplyFinishTime { get; set; }

        /// <summary>
        /// 申请单开始时间
        /// </summary>
        [XmlElement("apply_start_time")]
        public string ApplyStartTime { get; set; }

        /// <summary>
        /// 申请单状态
        /// </summary>
        [XmlElement("approval_status")]
        public string ApprovalStatus { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 审批单关联制度列表，当企业出资方式为企业出资且设置此字段非空时，会查询最优制度并发放额度至该最优制度关联的员工
        /// </summary>
        [XmlArray("institution_id_list")]
        [XmlArrayItem("string")]
        public List<string> InstitutionIdList { get; set; }

        /// <summary>
        /// 外部平台审批单id
        /// </summary>
        [XmlElement("platform_approval_id")]
        public string PlatformApprovalId { get; set; }

        /// <summary>
        /// 事由
        /// </summary>
        [XmlElement("purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// 同行人信息列表
        /// </summary>
        [XmlArray("traveler_list")]
        [XmlArrayItem("approval_traveler_d_t_o")]
        public List<ApprovalTravelerDTO> TravelerList { get; set; }

        /// <summary>
        /// 行程信息列表（传入覆盖修改）
        /// </summary>
        [XmlArray("trip_info_list")]
        [XmlArrayItem("approval_trip_d_t_o")]
        public List<ApprovalTripDTO> TripInfoList { get; set; }
    }
}
