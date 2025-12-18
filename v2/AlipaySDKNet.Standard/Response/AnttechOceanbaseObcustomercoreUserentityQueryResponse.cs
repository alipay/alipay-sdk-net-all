using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObcustomercoreUserentityQueryResponse.
    /// </summary>
    public class AnttechOceanbaseObcustomercoreUserentityQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 公司通行证角色信息DTO
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("o_b_passport_entity_d_t_o")]
        public List<OBPassportEntityDTO> Data { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 分页总数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }

        /// <summary>
        /// 数据体data的总条数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
