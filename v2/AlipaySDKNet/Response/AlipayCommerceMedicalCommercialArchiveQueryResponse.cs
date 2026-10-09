using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialArchiveQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalCommercialArchiveQueryResponse : AopResponse
    {
        /// <summary>
        /// 受益人集合
        /// </summary>
        [XmlArray("member_archive_list")]
        [XmlArrayItem("member_archive_open_api_info_d_t_o")]
        public List<MemberArchiveOpenApiInfoDTO> MemberArchiveList { get; set; }

        /// <summary>
        /// 记录数量
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
