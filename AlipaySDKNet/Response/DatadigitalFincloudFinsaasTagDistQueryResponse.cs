using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasTagDistQueryResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasTagDistQueryResponse : AopResponse
    {
        /// <summary>
        /// 标签取值列表
        /// </summary>
        [XmlArray("tag_dist_dto_list")]
        [XmlArrayItem("tag_dist_d_t_o")]
        public List<TagDistDTO> TagDistDtoList { get; set; }
    }
}
