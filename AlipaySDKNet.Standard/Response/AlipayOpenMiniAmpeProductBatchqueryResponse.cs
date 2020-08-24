using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeProductBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeProductBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 用户设备产品列表
        /// </summary>
        [XmlArray("product_list")]
        [XmlArrayItem("ampe_product_info")]
        public List<AmpeProductInfo> ProductList { get; set; }
    }
}
