using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingPaymentBatchqueryResponse.
    /// </summary>
    public class AlipayEbppIndustryCareertrainingPaymentBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 数据列表
        /// </summary>
        [XmlElement("list")]
        public PaymentObject List { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
