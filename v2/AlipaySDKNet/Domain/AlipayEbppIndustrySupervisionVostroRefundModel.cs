using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionVostroRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustrySupervisionVostroRefundModel : AopObject
    {
        /// <summary>
        /// 来帐通知中对应的入账账户
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 来帐通知中对应的入账账户 在子户账户创建时的子户庄户类型
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 不同的业务场景下对应不同的业务规则
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 对应来帐通知接口的「银行侧来账业务单号 order_no 」
        /// </summary>
        [XmlElement("org_order_no")]
        public string OrgOrderNo { get; set; }

        /// <summary>
        /// 商户内部生成的本次原路退请求流水号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }
    }
}
