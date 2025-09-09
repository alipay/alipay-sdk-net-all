using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSettleBatchFinishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSettleBatchFinishModel : AopObject
    {
        /// <summary>
        /// 批次金额，单位元，支持小数点后2位
        /// </summary>
        [XmlElement("batch_amount")]
        public string BatchAmount { get; set; }

        /// <summary>
        /// 批次币种,默认填写为CNY,表示人民币
        /// </summary>
        [XmlElement("batch_currency")]
        public string BatchCurrency { get; set; }

        /// <summary>
        /// 结算对手方信息,当前仅支持smid
        /// </summary>
        [XmlElement("batch_detail_info")]
        public BatchDetailUserInfo BatchDetailInfo { get; set; }

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
        /// 业务汇总维度，64个字符以内、可包含字母、数字、下划线；需保证在商户端不重复，如果重复则返回该维度下对应的结算批次的状态
        /// </summary>
        [XmlElement("dimension")]
        public string Dimension { get; set; }

        /// <summary>
        /// 结算请求外部流水号，32个字符以内、可包含字母、数字、下划线；需保证在商户端不重复，如果重复则返回该流水号对应的结算单据的状态。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
