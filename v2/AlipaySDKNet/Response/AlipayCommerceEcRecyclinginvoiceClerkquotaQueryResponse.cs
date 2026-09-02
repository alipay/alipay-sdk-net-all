using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceClerkquotaQueryResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceClerkquotaQueryResponse : AopResponse
    {
        /// <summary>
        /// 额度计算时间
        /// </summary>
        [XmlElement("calculate_time")]
        public string CalculateTime { get; set; }

        /// <summary>
        /// 企业（商户）营业员ID
        /// </summary>
        [XmlElement("company_clerk_id")]
        public string CompanyClerkId { get; set; }

        /// <summary>
        /// 锁定额度（元）= 在途未支付订单金额
        /// </summary>
        [XmlElement("locked_amount")]
        public string LockedAmount { get; set; }

        /// <summary>
        /// 额度类型
        /// </summary>
        [XmlElement("quota_type")]
        public string QuotaType { get; set; }

        /// <summary>
        /// 剩余额度（元）= 总额 - 锁定 - 已核销
        /// </summary>
        [XmlElement("remain_amount")]
        public string RemainAmount { get; set; }

        /// <summary>
        /// 总额度（元）= 当前营业员该额度类型的生效额度合计
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
