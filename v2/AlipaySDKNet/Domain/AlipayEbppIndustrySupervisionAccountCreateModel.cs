using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionAccountCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustrySupervisionAccountCreateModel : AopObject
    {
        /// <summary>
        /// 业务场景 + 关联账户号 + 待开通子户类型。 三个唯一确定一个最终开通的子户账号
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 驾校在支付宝中的uid 对应open_id 用于创建对应驾校的监管子户
        /// </summary>
        [XmlElement("merchant_alipay_open_id")]
        public string MerchantAlipayOpenId { get; set; }

        /// <summary>
        /// 驾校在支付宝中的uid 用于创建对应驾校的监管子户
        /// </summary>
        [XmlElement("merchant_alipay_uid")]
        public string MerchantAlipayUid { get; set; }

        /// <summary>
        /// 待开子户的关联账户号。 驾校在网商申请的最终结算户。
        /// </summary>
        [XmlElement("parent_ext_account_no")]
        public string ParentExtAccountNo { get; set; }

        /// <summary>
        /// 业务场景+ 待开子户关联账户+待开通子户类型 biz_scene + parent_ext_account_no +sub_account_type  最终申请出唯一的对应子户。
        /// </summary>
        [XmlElement("sub_account_type")]
        public string SubAccountType { get; set; }
    }
}
