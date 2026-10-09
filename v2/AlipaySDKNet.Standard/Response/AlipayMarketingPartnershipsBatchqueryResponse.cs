using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingPartnershipsBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingPartnershipsBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 合作关系列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("marketing_partner_ship")]
        public List<MarketingPartnerShip> Data { get; set; }

        /// <summary>
        /// 分页查询页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询单页数据条数。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 合作关系总数量。
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
