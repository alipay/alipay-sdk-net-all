using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingPassTemplateQueryResponse.
    /// </summary>
    public class AlipayMarketingPassTemplateQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前查询的页码，页码从1开始
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 当前查询的每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 卡券模板总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }

        /// <summary>
        /// 按page_size分页的总页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }

        /// <summary>
        /// 卡券模板列表
        /// </summary>
        [XmlArray("tpl_list")]
        [XmlArrayItem("pass_template_detail")]
        public List<PassTemplateDetail> TplList { get; set; }
    }
}
