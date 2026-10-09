using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoanapplyApplyQueryResponse.
    /// </summary>
    public class MybankCreditLoanapplyApplyQueryResponse : AopResponse
    {
        /// <summary>
        /// 申请贷款额度
        /// </summary>
        [XmlElement("apply_amt")]
        public string ApplyAmt { get; set; }

        /// <summary>
        /// 申请日期
        /// </summary>
        [XmlElement("apply_date")]
        public string ApplyDate { get; set; }

        /// <summary>
        /// 申请单编号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 申请状态
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 审批结论，审批通过或者拒绝
        /// </summary>
        [XmlElement("approve_conclu")]
        public string ApproveConclu { get; set; }

        /// <summary>
        /// 审批通过后返回的授信信息
        /// </summary>
        [XmlElement("approve_credit_result")]
        public ApproveCreditResult ApproveCreditResult { get; set; }

        /// <summary>
        /// 审批完成时间
        /// </summary>
        [XmlElement("approve_finish_date")]
        public string ApproveFinishDate { get; set; }

        /// <summary>
        /// 客户机构ISV ipRoleId
        /// </summary>
        [XmlElement("cust_inst_appid")]
        public string CustInstAppid { get; set; }

        /// <summary>
        /// 客户机构ipRoleId
        /// </summary>
        [XmlElement("cust_inst_code")]
        public string CustInstCode { get; set; }

        /// <summary>
        /// 返回的扩展字段，预留
        /// </summary>
        [XmlElement("ext_json")]
        public string ExtJson { get; set; }

        /// <summary>
        /// 数据项的采集结果
        /// </summary>
        [XmlArray("investig_category_result")]
        [XmlArrayItem("investig_category_result")]
        public List<InvestigCategoryResult> InvestigCategoryResult { get; set; }

        /// <summary>
        /// 参与者角色ID
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 申贷类型
        /// </summary>
        [XmlElement("loan_type")]
        public string LoanType { get; set; }

        /// <summary>
        /// 运营产品CODE
        /// </summary>
        [XmlElement("op_prod_code")]
        public string OpProdCode { get; set; }

        /// <summary>
        /// 运营产品CODE版本
        /// </summary>
        [XmlElement("op_prod_code_version")]
        public string OpProdCodeVersion { get; set; }

        /// <summary>
        /// 审批拒绝原因CODE，多个以逗号分隔，默认为null
        /// </summary>
        [XmlElement("refuse_code")]
        public string RefuseCode { get; set; }

        /// <summary>
        /// 调查结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }
    }
}
