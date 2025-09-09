using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSettleBatchFinishResponse.
    /// </summary>
    public class AlipayTradeSettleBatchFinishResponse : AopResponse
    {
        /// <summary>
        /// 批次金额,单位分
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
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// FAIL  失败 ACCEPT_SUCCESS  受理成功，等待关账结果通知
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
