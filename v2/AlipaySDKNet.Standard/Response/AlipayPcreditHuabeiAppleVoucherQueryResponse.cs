using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiAppleVoucherQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiAppleVoucherQueryResponse : AopResponse
    {
        /// <summary>
        /// 券额度，单位分
        /// </summary>
        [XmlElement("credit_amount")]
        public long CreditAmount { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 额度券实例号
        /// </summary>
        [XmlElement("instance_no")]
        public string InstanceNo { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// valid表示生效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 已领苹果专享额度券列表
        /// </summary>
        [XmlArray("vouchers")]
        [XmlArrayItem("apple_voucher_query_item")]
        public List<AppleVoucherQueryItem> Vouchers { get; set; }
    }
}
