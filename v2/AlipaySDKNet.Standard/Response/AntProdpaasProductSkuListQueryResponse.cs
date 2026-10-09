using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntProdpaasProductSkuListQueryResponse.
    /// </summary>
    public class AntProdpaasProductSkuListQueryResponse : AopResponse
    {
        /// <summary>
        /// 状态码(success|failure)
        /// </summary>
        [XmlElement("flag")]
        public string Flag { get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlElement("item")]
        public SupplierSkuInfo Item { get; set; }
    }
}
