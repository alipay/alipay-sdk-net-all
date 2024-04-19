using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmRolePageQueryResponse.
    /// </summary>
    public class AlipayIserviceCcmRolePageQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询结果的页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询时设置的每页记录数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 角色列表
        /// </summary>
        [XmlArray("roles")]
        [XmlArrayItem("role")]
        public List<Role> Roles { get; set; }

        /// <summary>
        /// 总条目数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
