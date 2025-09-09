using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingBusinessbillGoodsQueryResponse.
    /// </summary>
    public class AlipayMarketingBusinessbillGoodsQueryResponse : AopResponse
    {
        /// <summary>
        /// 页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 经营收款单商品查询模型
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("business_bill_goods_query_page_v_o")]
        public List<BusinessBillGoodsQueryPageVO> ResultList { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 总条目数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
