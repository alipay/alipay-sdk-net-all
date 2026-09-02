using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiAppleVoucherReceiveResponse.
    /// </summary>
    public class AlipayPcreditHuabeiAppleVoucherReceiveResponse : AopResponse
    {
        /// <summary>
        /// 提额额度，单位分
        /// </summary>
        [XmlElement("credit_amount")]
        public long CreditAmount { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 幂等命中true、未命中false
        /// </summary>
        [XmlElement("idempotent")]
        public bool Idempotent { get; set; }

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
    }
}
