using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasDesignPagetemplateBatchqueryResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasDesignPagetemplateBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 该查询的数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 运营任务列表
        /// </summary>
        [XmlArray("template_list")]
        [XmlArrayItem("page_template_info_d_t_o")]
        public List<PageTemplateInfoDTO> TemplateList { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
