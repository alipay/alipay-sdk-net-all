using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardAftersalesQueryResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardAftersalesQueryResponse : AopResponse
    {
        /// <summary>
        /// 售后详情
        /// </summary>
        [XmlElement("aftersales_info")]
        public AftersalesInfo AftersalesInfo { get; set; }
    }
}
