using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenInstantdeliveryMerchantshopBatchqueryResponse.
    /// </summary>
    public class AlipayOpenInstantdeliveryMerchantshopBatchqueryResponse : AopResponse
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
        /// 门店列表数据。
        /// </summary>
        [XmlElement("records")]
        public MerchantShopDTO Records { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_no")]
        public long TotalNo { get; set; }
    }
}
