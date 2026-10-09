using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistSrcfgestagecreditSecondApproveModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistSrcfgestagecreditSecondApproveModel : AopObject
    {
        /// <summary>
        /// 政企员工团购分期授信初审的申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 员工政企单位统一社会信用代码，外部复审结果通过时必传
        /// </summary>
        [XmlElement("gov_enter_cert_no")]
        public string GovEnterCertNo { get; set; }

        /// <summary>
        /// 员工政企单位名称，外部复审结果通过时必传
        /// </summary>
        [XmlElement("gov_enter_name")]
        public string GovEnterName { get; set; }

        /// <summary>
        /// 平台为接入客户分配
        /// </summary>
        [XmlElement("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 员工是否为领导标识，NOT_LEADER-不是领导 、LEADER-是领导
        /// </summary>
        [XmlElement("leader_flag")]
        public string LeaderFlag { get; set; }

        /// <summary>
        /// 唯一标识政企员工团购分期授信请求
        /// </summary>
        [XmlElement("out_bsn_no")]
        public string OutBsnNo { get; set; }

        /// <summary>
        /// 外部复审结果
        /// </summary>
        [XmlElement("out_review_result")]
        public string OutReviewResult { get; set; }

        /// <summary>
        /// 业务所属产品，平台为业务分配
        /// </summary>
        [XmlElement("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 政企员工的身份证号
        /// </summary>
        [XmlElement("user_id_card")]
        public string UserIdCard { get; set; }

        /// <summary>
        /// 政企员工的姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 政企员工名下手机号
        /// </summary>
        [XmlElement("user_phone")]
        public string UserPhone { get; set; }
    }
}
