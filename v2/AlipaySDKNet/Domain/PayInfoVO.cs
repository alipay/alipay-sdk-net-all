using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class PayInfoVO : AopObject
    {
        /// <summary>
        /// 支付渠道列表
        /// </summary>
        [XmlArray("pay_channels")]
        [XmlArrayItem("string")]
        public List<string> PayChannels { get; set; }

        /// <summary>
        /// 付款时间，yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 支付流水单号
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 券明细 当前字段已废弃(支付券优惠根据alipay.trade.query查询)
        /// </summary>
        [XmlArray("voucher_detail_list")]
        [XmlArrayItem("voucher_detail_info_d_t_o")]
        public List<VoucherDetailInfoDTO> VoucherDetailList { get; set; }
    }
}
