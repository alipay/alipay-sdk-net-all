using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupGroupoptionAssistantQueryResponse.
    /// </summary>
    public class AlipayMerchantGroupGroupoptionAssistantQueryResponse : AopResponse
    {
        /// <summary>
        /// 群组选项列表
        /// </summary>
        [XmlArray("group_options")]
        [XmlArrayItem("group_option_v_o")]
        public List<GroupOptionVO> GroupOptions { get; set; }
    }
}
