using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BatchFinishInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BatchFinishInfo : AopObject
    {
        /// <summary>
        /// 批次金额
        /// </summary>
        [XmlElement("batch_amount")]
        public string BatchAmount { get; set; }

        /// <summary>
        /// 批次币种,本次成功场景下默认返回CNY
        /// </summary>
        [XmlElement("batch_currency")]
        public string BatchCurrency { get; set; }

        /// <summary>
        /// 支付宝侧结算批次id,全局唯一
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 批次明细数量
        /// </summary>
        [XmlElement("batch_num")]
        public long BatchNum { get; set; }

        /// <summary>
        /// 成功:S,失败:F,处理中:P
        /// </summary>
        [XmlElement("batch_status")]
        public string BatchStatus { get; set; }

        /// <summary>
        /// 分账:alloc;结算:settle
        /// </summary>
        [XmlElement("batch_type")]
        public string BatchType { get; set; }

        /// <summary>
        /// 汇总维度
        /// </summary>
        [XmlElement("dimension")]
        public string Dimension { get; set; }

        /// <summary>
        /// 成功时间，在关单成功的情况下才会返回
        /// </summary>
        [XmlElement("gmt_success")]
        public string GmtSuccess { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
