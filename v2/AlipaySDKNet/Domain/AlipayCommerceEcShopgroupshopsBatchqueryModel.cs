using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcShopgroupshopsBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcShopgroupshopsBatchqueryModel : AopObject
    {
        /// <summary>
        /// 企业码企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 是否返回指定的行业数据详情
        /// </summary>
        [XmlElement("industry_query_option")]
        public IndustryQueryOption IndustryQueryOption { get; set; }

        /// <summary>
        /// 页码，最小1
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 页大小，最大100
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 门店组id
        /// </summary>
        [XmlElement("shop_group_id")]
        public string ShopGroupId { get; set; }
    }
}
