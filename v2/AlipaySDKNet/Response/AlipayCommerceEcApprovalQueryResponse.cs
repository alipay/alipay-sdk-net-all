using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcApprovalQueryResponse.
    /// </summary>
    public class AlipayCommerceEcApprovalQueryResponse : AopResponse
    {
        /// <summary>
        /// 审批结果，可选值： APPLYING-申请中；VALID-已生效；CANCELLED-已取消；REJECTED-已驳回
        /// </summary>
        [XmlElement("approval_result")]
        public string ApprovalResult { get; set; }

        /// <summary>
        /// 同行人信息列表
        /// </summary>
        [XmlArray("approval_traveler_dto_list")]
        [XmlArrayItem("approval_traveler_d_t_o")]
        public List<ApprovalTravelerDTO> ApprovalTravelerDtoList { get; set; }

        /// <summary>
        /// 行程信息列表
        /// </summary>
        [XmlArray("approval_trip_dto_list")]
        [XmlArrayItem("approval_trip_d_t_o")]
        public List<ApprovalTripDTO> ApprovalTripDtoList { get; set; }

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
        /// 外部平台审批单id
        /// </summary>
        [XmlElement("platform_approval_id")]
        public string PlatformApprovalId { get; set; }

        /// <summary>
        /// 事由
        /// </summary>
        [XmlElement("purpose")]
        public string Purpose { get; set; }
    }
}
