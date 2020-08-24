using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeDevicemodelBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeDevicemodelBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 产品机型列表
        /// </summary>
        [XmlElement("product_info")]
        public AmpeProductInfo ProductInfo { get; set; }
    }
}
