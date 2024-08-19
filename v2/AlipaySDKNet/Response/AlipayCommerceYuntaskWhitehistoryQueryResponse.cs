using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskWhitehistoryQueryResponse.
    /// </summary>
    public class AlipayCommerceYuntaskWhitehistoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页数
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 每页大小，单位个，例如10个
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总记录数，单位个，比如100个
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }

        /// <summary>
        /// 白名单列表
        /// </summary>
        [XmlArray("white_list")]
        [XmlArrayItem("yun_task_white_user_d_t_o")]
        public List<YunTaskWhiteUserDTO> WhiteList { get; set; }
    }
}
