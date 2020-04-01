using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandShopBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandShopBatchqueryModel : AopObject
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页数量, 最大50
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 插件业务场景code，预约为SHOP_SERVICE
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 线上店ID
        /// </summary>
        [XmlElement("store_open_id")]
        public string StoreOpenId { get; set; }
    }
}
