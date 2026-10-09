using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinInsuranceApplyCreateResponse.
    /// </summary>
    public class AnttechBlockchainDefinInsuranceApplyCreateResponse : AopResponse
    {
        /// <summary>
        /// 保额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 投保单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 保险止期
        /// </summary>
        [XmlElement("insure_end_date")]
        public string InsureEndDate { get; set; }

        /// <summary>
        /// 保险起期
        /// </summary>
        [XmlElement("insure_start_date")]
        public string InsureStartDate { get; set; }

        /// <summary>
        /// 个性化参数
        /// </summary>
        [XmlElement("parm")]
        public string Parm { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 电子保单链接
        /// </summary>
        [XmlElement("policy_url")]
        public string PolicyUrl { get; set; }

        /// <summary>
        /// 保费
        /// </summary>
        [XmlElement("premium")]
        public string Premium { get; set; }

        /// <summary>
        /// 请求交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
