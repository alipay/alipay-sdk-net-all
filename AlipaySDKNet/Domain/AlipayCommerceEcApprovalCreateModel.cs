using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcApprovalCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcApprovalCreateModel : AopObject
    {
        /// <summary>
        /// 员工id
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 审批单关联制度列表
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
        /// 行程信息列表
        /// </summary>
        [XmlArray("trip_info_list")]
        [XmlArrayItem("approval_trip_d_t_o")]
        public List<ApprovalTripDTO> TripInfoList { get; set; }
    }
}
