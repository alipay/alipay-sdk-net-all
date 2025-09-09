using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistCarfinApplystatusencryptNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistCarfinApplystatusencryptNotifyModel : AopObject
    {
        /// <summary>
        /// 星河侧唯一申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 客户贷款列表
        /// </summary>
        [XmlArray("loan_list")]
        [XmlArrayItem("org_loan_detail")]
        public List<OrgLoanDetail> LoanList { get; set; }

        /// <summary>
        /// 机构侧状态码
        /// </summary>
        [XmlElement("org_status")]
        public string OrgStatus { get; set; }

        /// <summary>
        /// 机构侧唯一业务编号
        /// </summary>
        [XmlElement("out_apply_no")]
        public string OutApplyNo { get; set; }

        /// <summary>
        /// 客户申请状态： APPLIED：已申请；FOLLOWING：客服跟进中；WILLING：客户有意愿；NO_WILLING：客户无意愿；PRE_REJECT：预审拒绝；PRE_PASS：预审通过；APPROVING：审批中；APPROVE_REJECT：审批拒绝；APPROVE_PASS：审批通过；SIGNING：签约中；SIGN_FAIL：签约失败；SIGNED：合同已生效；LENDING：放款中；LEND_REJECT：放款拒绝；LEND_SUC：已放款
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
