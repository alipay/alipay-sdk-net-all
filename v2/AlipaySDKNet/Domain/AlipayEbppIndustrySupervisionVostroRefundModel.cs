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
        /// 网商来帐通知对应子户户号，用于原路退校验
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 网商来帐通知对应子户类型
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 退款金额，当前只支持原单全额退.单位分
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 原网商来帐单号（order_no）
        /// </summary>
        [XmlElement("org_order_no")]
        public string OrgOrderNo { get; set; }

        /// <summary>
        /// 业务流水号，相同请求幂等返回
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }
    }
}
