using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentRoyaltyBillQueryResponse.
    /// </summary>
    public class AlipayCommerceRentRoyaltyBillQueryResponse : AopResponse
    {
        /// <summary>
        /// 分账账单列表
        /// </summary>
        [XmlArray("royalty_bill_info_list")]
        [XmlArrayItem("rent_royalty_bill_info_d_t_o")]
        public List<RentRoyaltyBillInfoDTO> RoyaltyBillInfoList { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
