using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcAccountingentityPageQueryResponse.
    /// </summary>
    public class AlipayCommerceEcAccountingentityPageQueryResponse : AopResponse
    {
        /// <summary>
        /// 核算主体列表
        /// </summary>
        [XmlArray("accounting_entity_list")]
        [XmlArrayItem("accounting_entity_info_d_t_o")]
        public List<AccountingEntityInfoDTO> AccountingEntityList { get; set; }

        /// <summary>
        /// 当前页数
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 核算主体总数量
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }
    }
}
