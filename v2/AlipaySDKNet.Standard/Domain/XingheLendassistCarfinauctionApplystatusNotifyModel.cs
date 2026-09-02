using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistCarfinauctionApplystatusNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistCarfinauctionApplystatusNotifyModel : AopObject
    {
        /// <summary>
        /// 星河侧唯一申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("credit_list")]
        [XmlArrayItem("auc_credit")]
        public List<AucCredit> CreditList { get; set; }

        /// <summary>
        /// 放款信息
        /// </summary>
        [XmlElement("loan_info")]
        public AucLoanInfo LoanInfo { get; set; }

        /// <summary>
        /// 机构侧唯一业务编号
        /// </summary>
        [XmlElement("out_apply_no")]
        public string OutApplyNo { get; set; }

        /// <summary>
        /// 拒绝码
        /// </summary>
        [XmlElement("refuse_code")]
        public string RefuseCode { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        [XmlElement("refuse_msg")]
        public string RefuseMsg { get; set; }

        /// <summary>
        /// 客户申请状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
