using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppItemCatespuQueryResponse.
    /// </summary>
    public class AlipayOpenAppItemCatespuQueryResponse : AopResponse
    {
        /// <summary>
        /// 分页查询的页码。默认从1开始
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询的每页记录数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("spu_infos")]
        [XmlArrayItem("spu_info_v_o")]
        public List<SpuInfoVO> SpuInfos { get; set; }

        /// <summary>
        /// 查询返回总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
