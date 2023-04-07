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
        /// 0: 支付类型
        /// </summary>
        [XmlElement("pay_method_type")]
        public string PayMethodType { get; set; }

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
        /// 券明细
        /// </summary>
        [XmlArray("voucher_detail_list")]
        [XmlArrayItem("voucher_detail_info_d_t_o")]
        public List<VoucherDetailInfoDTO> VoucherDetailList { get; set; }
    }
}
