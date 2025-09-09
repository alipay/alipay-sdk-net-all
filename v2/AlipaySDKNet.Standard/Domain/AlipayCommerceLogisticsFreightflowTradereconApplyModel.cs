using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowTradereconApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsFreightflowTradereconApplyModel : AopObject
    {
        /// <summary>
        /// 物流公司编码，由支付宝分配
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 银行管理模式。 本期： ANT_MYBANK(网商银行模式)
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 网商银行应用id,当mode为ANT_MYBANK时由网商提供给商户
        /// </summary>
        [XmlElement("mybank_app_id")]
        public string MybankAppId { get; set; }

        /// <summary>
        /// 业务幂等号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 如果mode为网商银行，则为网商银行分配
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 账单日期，格式为yyyyMMdd 日期规则如下: 1. query_date < Today (当日生成昨日对账单，所以申请时间需早于当日) 2. 六个月前的当月一日 <= query_date 3. isv入驻时间 <= query_date
        /// </summary>
        [XmlElement("query_date")]
        public string QueryDate { get; set; }

        /// <summary>
        /// 下载账单类型 交易对账单：SYSTEM_TRADE_RECON 交易明细对账单：SYSTEM_TRADE_DETAIL_RECON
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }
    }
}
