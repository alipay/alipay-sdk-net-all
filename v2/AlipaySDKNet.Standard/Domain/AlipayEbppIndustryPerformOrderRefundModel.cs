using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryPerformOrderRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryPerformOrderRefundModel : AopObject
    {
        /// <summary>
        /// 行业业务订单号，即通过行业受理平台创建的业务单据
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 是否间联商户(是间联传Y,其他可不填) 非签约pid调用时必传Y(默认N)
        /// </summary>
        [XmlElement("is_sub_merchant")]
        public string IsSubMerchant { get; set; }

        /// <summary>
        /// 商户外部唯一订单号,billNo或tradeNo为空时必填
        /// </summary>
        [XmlElement("out_no")]
        public string OutNo { get; set; }

        /// <summary>
        /// 设置此参数进行退分账，只对直付通模式-部分退分账场景生效。全额退款默认全额退分账，不用单独设置该字段。
        /// </summary>
        [XmlArray("profit_sharing_list")]
        [XmlArrayItem("profit_sharing")]
        public List<ProfitSharing> ProfitSharingList { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 需要退款的金额，该金额不能大于订单金额，支持两位小数。默认不传则全额退款(推荐)。
        /// </summary>
        [XmlElement("refund_money")]
        public string RefundMoney { get; set; }

        /// <summary>
        /// 默认异步退款
        /// </summary>
        [XmlElement("refund_scene")]
        public string RefundScene { get; set; }

        /// <summary>
        /// 部分退款商家请求号,部分退款必传
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
