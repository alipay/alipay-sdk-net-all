using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransMergeDetailQueryResponse.
    /// </summary>
    public class AlipayFundTransMergeDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 分渠道金额汇总
        /// </summary>
        [XmlElement("amount_statistics")]
        public string AmountStatistics { get; set; }

        /// <summary>
        /// 总失败金额
        /// </summary>
        [XmlElement("fail_total_amount")]
        public string FailTotalAmount { get; set; }

        /// <summary>
        /// 总失败笔数
        /// </summary>
        [XmlElement("fail_total_count")]
        public string FailTotalCount { get; set; }

        /// <summary>
        /// 明细列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("merge_pay_order")]
        public List<MergePayOrder> ItemList { get; set; }

        /// <summary>
        /// 合并单号
        /// </summary>
        [XmlElement("merge_order_id")]
        public string MergeOrderId { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 支付宝登录号
        /// </summary>
        [XmlElement("payer_logon_id")]
        public string PayerLogonId { get; set; }

        /// <summary>
        /// 业务上需要展示付款方名字
        /// </summary>
        [XmlElement("payer_name")]
        public string PayerName { get; set; }

        /// <summary>
        /// 单据状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 总成功金额
        /// </summary>
        [XmlElement("success_total_amount")]
        public string SuccessTotalAmount { get; set; }

        /// <summary>
        /// 总成功笔数
        /// </summary>
        [XmlElement("success_total_count")]
        public string SuccessTotalCount { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 总笔数
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }
    }
}
