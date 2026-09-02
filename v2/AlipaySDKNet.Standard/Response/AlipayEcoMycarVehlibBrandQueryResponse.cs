using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarVehlibBrandQueryResponse.
    /// </summary>
    public class AlipayEcoMycarVehlibBrandQueryResponse : AopResponse
    {
        /// <summary>
        /// 品牌列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("veh_open_brand_d_t_o")]
        public List<VehOpenBrandDTO> List { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }

        /// <summary>
        /// 符合条件的总记录数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
