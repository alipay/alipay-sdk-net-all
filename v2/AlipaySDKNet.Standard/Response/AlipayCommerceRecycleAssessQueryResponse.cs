using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleAssessQueryResponse.
    /// </summary>
    public class AlipayCommerceRecycleAssessQueryResponse : AopResponse
    {
        /// <summary>
        /// 估价集合
        /// </summary>
        [XmlArray("assess_info_list")]
        [XmlArrayItem("recycle_assess_d_t_o")]
        public List<RecycleAssessDTO> AssessInfoList { get; set; }
    }
}
