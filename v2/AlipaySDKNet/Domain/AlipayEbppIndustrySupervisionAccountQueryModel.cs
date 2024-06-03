using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionAccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustrySupervisionAccountQueryModel : AopObject
    {
        /// <summary>
        /// 专款子户户号 专款钱包必填
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 业务场景 + 待开通子户类型。 确定开通的子户账号
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 企业支付宝的uid 对应open_id 用于查询对应的监管子户
        /// </summary>
        [XmlElement("merchant_alipay_open_id")]
        public string MerchantAlipayOpenId { get; set; }

        /// <summary>
        /// 企业支付宝中的uid 用于查询对应的监管子户
        /// </summary>
        [XmlElement("merchant_alipay_uid")]
        public string MerchantAlipayUid { get; set; }

        /// <summary>
        /// 待开子户的关联账户号。 企业在网商申请的最终结算户。
        /// </summary>
        [XmlElement("parent_ext_account_no")]
        public string ParentExtAccountNo { get; set; }

        /// <summary>
        /// 业务场景+ 开通子户类型 biz_scene +sub_account_type 最终确定唯一的对应子户。。 专款账户母户余额查询 传入 SPECIAL_FUNDS_DEPOSIT
        /// </summary>
        [XmlElement("sub_account_type")]
        public string SubAccountType { get; set; }
    }
}
