using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpOpporPageQueryResponse.
    /// </summary>
    public class AlipayOpenSpOpporPageQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 商机作业记录列表
        /// </summary>
        [XmlArray("oppor_list")]
        [XmlArrayItem("isv_expand_oppor_d_t_o")]
        public List<IsvExpandOpporDTO> OpporList { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
