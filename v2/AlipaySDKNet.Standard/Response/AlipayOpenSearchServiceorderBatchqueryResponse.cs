using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSearchServiceorderBatchqueryResponse.
    /// </summary>
    public class AlipayOpenSearchServiceorderBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 申请单列表
        /// </summary>
        [XmlElement("data")]
        public OrderPageQueryDTO Data { get; set; }
    }
}
