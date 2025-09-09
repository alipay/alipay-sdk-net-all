using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppItemBrandQueryResponse.
    /// </summary>
    public class AlipayOpenAppItemBrandQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("brand_info_list")]
        [XmlArrayItem("brand_info_v_o")]
        public List<BrandInfoVO> BrandInfoList { get; set; }

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
        /// 查询返回总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
