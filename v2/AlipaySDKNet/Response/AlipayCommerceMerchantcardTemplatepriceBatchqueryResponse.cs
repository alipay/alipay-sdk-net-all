using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardTemplatepriceBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardTemplatepriceBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("content")]
        [XmlArrayItem("merchant_card_template_price_item")]
        public List<MerchantCardTemplatePriceItem> Content { get; set; }

        /// <summary>
        /// 当前页码。
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 符合条件的价格明细总数。
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 符合条件的总页数。
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }
    }
}
