using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoanapplyApplyCreateResponse.
    /// </summary>
    public class MybankCreditLoanapplyApplyCreateResponse : AopResponse
    {
        /// <summary>
        /// 申请单编号，展示给客户，无业务意义
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 客户在网商银行的角色ID
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 子申请单号，唯一标识一笔申请，业务使用
        /// </summary>
        [XmlElement("sub_apply_no")]
        public string SubApplyNo { get; set; }
    }
}
