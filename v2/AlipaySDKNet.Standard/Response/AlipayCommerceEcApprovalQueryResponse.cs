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
        /// 申请单的结束时间
        /// </summary>
        [XmlElement("apply_finish_time")]
        public string ApplyFinishTime { get; set; }

        /// <summary>
        /// 申请单的开始时间
        /// </summary>
        [XmlElement("apply_start_time")]
        public string ApplyStartTime { get; set; }

        /// <summary>
        /// 审批结果（审批单状态）
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
        /// 申请单类型
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

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
        /// 二级场景，更多枚举请见：
        /// </summary>
        [XmlElement("expense_type_sub_category")]
        public string ExpenseTypeSubCategory { get; set; }

        /// <summary>
        /// 支付类型
        /// </summary>
        [XmlElement("payment_type")]
        public string PaymentType { get; set; }

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
        /// 一级场景，更多枚举请见：
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
