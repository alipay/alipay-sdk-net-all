using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneInshealthserviceprodMallitemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInshealthserviceprodMallitemQueryModel : AopObject
    {
        /// <summary>
        /// 服务产品ID
        /// </summary>
        [XmlElement("ser_prod_no")]
        public string SerProdNo { get; set; }

        /// <summary>
        /// 商家商品Id
        /// </summary>
        [XmlElement("source_product_id")]
        public string SourceProductId { get; set; }
    }
}
