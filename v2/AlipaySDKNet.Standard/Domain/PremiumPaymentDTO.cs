using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PremiumPaymentDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PremiumPaymentDTO : AopObject
    {
        /// <summary>
        /// 收款账号名
        /// </summary>
        [XmlElement("in_account_name")]
        public string InAccountName { get; set; }

        /// <summary>
        /// 收款账号
        /// </summary>
        [XmlElement("in_account_no")]
        public string InAccountNo { get; set; }

        /// <summary>
        /// 收入账号类型
        /// </summary>
        [XmlElement("in_account_type")]
        public string InAccountType { get; set; }

        /// <summary>
        /// 保险预下单id
        /// </summary>
        [XmlElement("ins_pre_order_id")]
        public string InsPreOrderId { get; set; }

        /// <summary>
        /// 支出账号名
        /// </summary>
        [XmlElement("out_account_name")]
        public string OutAccountName { get; set; }

        /// <summary>
        /// 支出账号
        /// </summary>
        [XmlElement("out_account_no")]
        public string OutAccountNo { get; set; }

        /// <summary>
        /// 支出账号类型
        /// </summary>
        [XmlElement("out_account_type")]
        public string OutAccountType { get; set; }

        /// <summary>
        /// 打款账单号
        /// </summary>
        [XmlElement("pay_bill_no")]
        public string PayBillNo { get; set; }

        /// <summary>
        /// 打款渠道类型
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 打款金额
        /// </summary>
        [XmlElement("pay_fee")]
        public long PayFee { get; set; }

        /// <summary>
        /// 打款订单号
        /// </summary>
        [XmlElement("pay_order_no")]
        public string PayOrderNo { get; set; }

        /// <summary>
        /// 打款业务单号
        /// </summary>
        [XmlElement("pay_out_biz_no")]
        public string PayOutBizNo { get; set; }

        /// <summary>
        /// 打款时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 产品编码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 保险报价id-无预下单时传入
        /// </summary>
        [XmlElement("quote_id")]
        public string QuoteId { get; set; }

        /// <summary>
        /// 投保推荐id
        /// </summary>
        [XmlElement("recommend_flow_id")]
        public string RecommendFlowId { get; set; }
    }
}
