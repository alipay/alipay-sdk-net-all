using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandStoreShopserviceCreateResponse.
    /// </summary>
    public class AntMerchantExpandStoreShopserviceCreateResponse : AopResponse
    {
        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 场景服务ID
        /// </summary>
        [XmlElement("shop_service_id")]
        public string ShopServiceId { get; set; }

        /// <summary>
        /// 规格ID
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
