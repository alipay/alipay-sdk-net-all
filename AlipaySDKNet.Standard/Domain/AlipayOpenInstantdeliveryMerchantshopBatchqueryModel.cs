using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenInstantdeliveryMerchantshopBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenInstantdeliveryMerchantshopBatchqueryModel : AopObject
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页数量, 最大50。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 商家门店编码。
        /// </summary>
        [XmlElement("shop_no")]
        public string ShopNo { get; set; }
    }
}
