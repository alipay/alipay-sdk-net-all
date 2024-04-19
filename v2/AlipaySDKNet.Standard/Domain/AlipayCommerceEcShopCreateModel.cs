using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcShopCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcShopCreateModel : AopObject
    {
        /// <summary>
        /// 操作人ID
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 服务商发布的服务id
        /// </summary>
        [XmlElement("service_product_id")]
        public string ServiceProductId { get; set; }

        /// <summary>
        /// 门店信息
        /// </summary>
        [XmlElement("shop_info")]
        public EcShop ShopInfo { get; set; }
    }
}
