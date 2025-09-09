using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftPoapTenantQueryResponse.
    /// </summary>
    public class AnttechNftPoapTenantQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否有下一页
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 勋章信息列表
        /// </summary>
        [XmlArray("medal_list")]
        [XmlArrayItem("poap_info_d_t_o")]
        public List<PoapInfoDTO> MedalList { get; set; }

        /// <summary>
        /// 勋章总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
