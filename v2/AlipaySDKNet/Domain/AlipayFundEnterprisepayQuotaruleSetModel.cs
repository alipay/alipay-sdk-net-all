using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundEnterprisepayQuotaruleSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundEnterprisepayQuotaruleSetModel : AopObject
    {
        /// <summary>
        /// 企业签约共同账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 平台和企业的三方授权协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 场景码，联系支付宝分配
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 成员支付宝ID，当操作类型=MEMBER时，member_id和open_id必填其一
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 支付宝用户的openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 操作类型： ACCOUNT-账户（支持单笔，月） MEMBER-成员（支持单笔，日，月，季度，年，终身累计，自定义周期，一次性额度）
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 产品码，默认值 ENTERPRISE_PAY
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 额度列表： 额度类型不可重复。 额度金额：单位为元，精确到分（整数或小数点后两位及以内的小数）；金额设置为-1表示无限制额度（一次性额度不支持-1）。
        /// </summary>
        [XmlArray("quota_list")]
        [XmlArrayItem("joint_account_quota_d_t_o")]
        public List<JointAccountQuotaDTO> QuotaList { get; set; }
    }
}
