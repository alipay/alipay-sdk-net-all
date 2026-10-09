using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingThirdpartyRefundQueryResponse.
    /// </summary>
    public class AlipayMarketingThirdpartyRefundQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 当前页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 订单列表
        /// </summary>
        [XmlElement("query_result_list")]
        public ThirdPartyRefundExceptionOrderList QueryResultList { get; set; }

        /// <summary>
        /// 去重后的订单总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
