using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseserviceBindserviceQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceEnterpriseserviceBindserviceQueryResponse : AopResponse
    {
        /// <summary>
        /// 服务产品列表
        /// </summary>
        [XmlArray("service_product_list")]
        [XmlArrayItem("service_product_info")]
        public List<ServiceProductInfo> ServiceProductList { get; set; }
    }
}
