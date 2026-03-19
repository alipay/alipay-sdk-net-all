using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserMobilebillListQueryResponse.
    /// </summary>
    public class AlipayUserMobilebillListQueryResponse : AopResponse
    {
        /// <summary>
        /// 账单列表查询为空时，返回nu l l
        /// </summary>
        [XmlElement("bill_list_items")]
        public BillApiSingleItem BillListItems { get; set; }

        /// <summary>
        /// 查询出的账单列表，当查询不到账单时，为空
        /// </summary>
        [XmlElement("statistic_info")]
        public BillApiStatisticInfo StatisticInfo { get; set; }
    }
}
