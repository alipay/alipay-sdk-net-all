using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasOpenAmountPreconsultResponse.
    /// </summary>
    public class AlipayOverseasOpenAmountPreconsultResponse : AopResponse
    {
        /// <summary>
        /// 缴费金额信息
        /// </summary>
        [XmlElement("amount_info")]
        public TuitionISVAmountInfoDTO AmountInfo { get; set; }

        /// <summary>
        /// 外部参考号
        /// </summary>
        [XmlElement("reference_id")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// 金额试算结果
        /// </summary>
        [XmlElement("result")]
        public TuitionISVResult Result { get; set; }
    }
}
