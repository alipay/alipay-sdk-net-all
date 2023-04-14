using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundJointaccountFundallocListQueryResponse.
    /// </summary>
    public class AlipayFundJointaccountFundallocListQueryResponse : AopResponse
    {
        /// <summary>
        /// 执行详情列表
        /// </summary>
        [XmlArray("alloc_detail_list")]
        [XmlArrayItem("alloc_detail_d_t_o")]
        public List<AllocDetailDTO> AllocDetailList { get; set; }

        /// <summary>
        /// 本次查询最后一条调拨记录的标识
        /// </summary>
        [XmlElement("last_id")]
        public string LastId { get; set; }
    }
}
