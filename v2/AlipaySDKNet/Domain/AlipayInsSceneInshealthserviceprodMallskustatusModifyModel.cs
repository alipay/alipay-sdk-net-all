using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneInshealthserviceprodMallskustatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInshealthserviceprodMallskustatusModifyModel : AopObject
    {
        /// <summary>
        /// 商家SKU编码
        /// </summary>
        [XmlElement("merchant_sku_code")]
        public string MerchantSkuCode { get; set; }

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

        /// <summary>
        /// 供应状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
