using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandStoreShopserviceDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandStoreShopserviceDeleteModel : AopObject
    {
        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 线下店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 场景服务ID
        /// </summary>
        [XmlElement("shop_service_id")]
        public string ShopServiceId { get; set; }

        /// <summary>
        /// SKU的ID
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 线上门店ID，插件协议的入参
        /// </summary>
        [XmlElement("store_open_id")]
        public string StoreOpenId { get; set; }
    }
}
