using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceDecorationPolicyunderwritingConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceDecorationPolicyunderwritingConsultModel : AopObject
    {
        /// <summary>
        /// 投保申请时间,格式：yyyy-MM-dd HH24:mm:ss,一般是系统当前时间,不传默认系统当前时间
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 支持的保司编码
        /// </summary>
        [XmlElement("insurance_company_code")]
        public string InsuranceCompanyCode { get; set; }

        /// <summary>
        /// 被保人列表
        /// </summary>
        [XmlArray("insured_list")]
        [XmlArrayItem("insured_v_o")]
        public List<InsuredVO> InsuredList { get; set; }

        /// <summary>
        /// 订单金额,分为单位
        /// </summary>
        [XmlElement("order_amount")]
        public long OrderAmount { get; set; }

        /// <summary>
        /// 不可重复,幂等字段
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 格式：yyyy-MM-dd HH:mm:ss 不同产品止期不同，一般时分秒为23点59分59秒
        /// </summary>
        [XmlElement("policy_end_date")]
        public string PolicyEndDate { get; set; }

        /// <summary>
        /// 投保单位对象
        /// </summary>
        [XmlElement("policy_org_holder")]
        public PolicyOrgHolderVO PolicyOrgHolder { get; set; }

        /// <summary>
        /// Y 格式：yyyy-MM-dd HH:mm:ss 一般为投保次日零时 示例：2025-11-02 00:00:00
        /// </summary>
        [XmlElement("policy_start_date")]
        public string PolicyStartDate { get; set; }

        /// <summary>
        /// 家财: JiaCai 团意1:TuanYi1 团意2:TuanYi2
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 项目编号或合同编号
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 保险标的
        /// </summary>
        [XmlArray("subject_matter")]
        [XmlArrayItem("subject_matter_v_o")]
        public List<SubjectMatterVO> SubjectMatter { get; set; }
    }
}
