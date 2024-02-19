using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ObfBillAcceptanceRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ObfBillAcceptanceRequest : AopObject
    {
        /// <summary>
        /// 分摊规则-一次性计收/按时长分摊
        /// </summary>
        [XmlElement("amortization_rule")]
        public string AmortizationRule { get; set; }

        /// <summary>
        /// 整数类型，单位分，支持负数 如-1000，122323
        /// </summary>
        [XmlElement("bill_amount_cent")]
        public string BillAmountCent { get; set; }

        /// <summary>
        /// 币种简称，如：CNY、USD
        /// </summary>
        [XmlElement("bill_amount_currency_code")]
        public string BillAmountCurrencyCode { get; set; }

        /// <summary>
        /// 订单结束时间时间戳
        /// </summary>
        [XmlElement("bill_end_date")]
        public string BillEndDate { get; set; }

        /// <summary>
        /// 业务账期
        /// </summary>
        [XmlElement("bill_period")]
        public string BillPeriod { get; set; }

        /// <summary>
        /// 订单生效时间对应时间戳
        /// </summary>
        [XmlElement("bill_start_date")]
        public string BillStartDate { get; set; }

        /// <summary>
        /// 渠道商品code
        /// </summary>
        [XmlElement("channel_commodity_code")]
        public string ChannelCommodityCode { get; set; }

        /// <summary>
        /// 渠道商品名称
        /// </summary>
        [XmlElement("channel_commodity_name")]
        public string ChannelCommodityName { get; set; }

        /// <summary>
        /// 用户名称，可能是公司，也可能是个人客户
        /// </summary>
        [XmlElement("customer_name")]
        public string CustomerName { get; set; }

        /// <summary>
        /// 幂等键避免重复推送，由uid+orderId+来源类型组合而成
        /// </summary>
        [XmlElement("idempotent_key")]
        public string IdempotentKey { get; set; }

        /// <summary>
        /// 签约主体ou code
        /// </summary>
        [XmlElement("ou_code")]
        public string OuCode { get; set; }

        /// <summary>
        /// 我方签约主体名称
        /// </summary>
        [XmlElement("our_contract_entity")]
        public string OurContractEntity { get; set; }

        /// <summary>
        /// 外部订单ID
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 附加扩展信息，json串格式
        /// </summary>
        [XmlElement("properties")]
        public string Properties { get; set; }

        /// <summary>
        /// 百分比，带小数的字符串，四舍五入截取2位
        /// </summary>
        [XmlElement("settle_rate")]
        public string SettleRate { get; set; }

        /// <summary>
        /// AWS_MP， SELF_DOMESTIC 自运营国内, SELF_OVERSEAS 自运营海外
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// 来源的客户uid
        /// </summary>
        [XmlElement("source_uid")]
        public string SourceUid { get; set; }

        /// <summary>
        /// 上下游依据业务场景约定的字符串
        /// </summary>
        [XmlElement("strategy_identity")]
        public string StrategyIdentity { get; set; }

        /// <summary>
        /// 商品税率百分比
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }
    }
}
