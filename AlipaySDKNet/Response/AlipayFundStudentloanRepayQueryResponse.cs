using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundStudentloanRepayQueryResponse.
    /// </summary>
    public class AlipayFundStudentloanRepayQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务类型 A生源地 B高校
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 学生所在分行名称
        /// </summary>
        [XmlElement("branch_name")]
        public string BranchName { get; set; }

        /// <summary>
        /// 学生所在区县或高校
        /// </summary>
        [XmlElement("org_name")]
        public string OrgName { get; set; }

        /// <summary>
        /// 还款日期，格式yyyy-MM-dd
        /// </summary>
        [XmlElement("repay_date")]
        public string RepayDate { get; set; }

        /// <summary>
        /// 还款明细列表
        /// </summary>
        [XmlArray("repay_list")]
        [XmlArrayItem("repay_detail")]
        public List<RepayDetail> RepayList { get; set; }

        /// <summary>
        /// 学生当前应还金额汇总
        /// </summary>
        [XmlElement("should_amount")]
        public string ShouldAmount { get; set; }

        /// <summary>
        /// 李某
        /// </summary>
        [XmlElement("student_name")]
        public string StudentName { get; set; }
    }
}
