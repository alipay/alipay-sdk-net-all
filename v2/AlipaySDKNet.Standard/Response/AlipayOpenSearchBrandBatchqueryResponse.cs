using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSearchBrandBatchqueryResponse.
    /// </summary>
    public class AlipayOpenSearchBrandBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 品牌详情信息
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("brand_infos")]
        public List<BrandInfos> Data { get; set; }
    }
}
