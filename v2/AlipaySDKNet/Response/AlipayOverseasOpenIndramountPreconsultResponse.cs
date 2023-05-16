using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasOpenIndramountPreconsultResponse.
    /// </summary>
    public class AlipayOverseasOpenIndramountPreconsultResponse : AopResponse
    {
        /// <summary>
        /// 金额信息
        /// </summary>
        [XmlElement("amount_info")]
        public IndrISVAmountInfoDTO AmountInfo { get; set; }

        /// <summary>
        /// 金额试算结果
        /// </summary>
        [XmlElement("result")]
        public IndrISVResult Result { get; set; }
    }
}
