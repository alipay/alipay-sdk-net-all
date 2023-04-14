using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundEnterprisepayManageApproveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundEnterprisepayManageApproveModel : AopObject
    {
        /// <summary>
        /// 共同账户id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 申请人信息
        /// </summary>
        [XmlElement("applicant_info")]
        public IdentityInfo ApplicantInfo { get; set; }

        /// <summary>
        /// 管理员信息；默认没有管理员，此时会以企业创建者为管理员。 目前只有企业码侧存在管理员这个概念。
        /// </summary>
        [XmlElement("approve_info")]
        public IdentityInfo ApproveInfo { get; set; }

        /// <summary>
        /// 业务场景，联系支付宝分配
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 管理员审批操作 枚举值：APPROVE REJECT
        /// </summary>
        [XmlElement("operation")]
        public string Operation { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
