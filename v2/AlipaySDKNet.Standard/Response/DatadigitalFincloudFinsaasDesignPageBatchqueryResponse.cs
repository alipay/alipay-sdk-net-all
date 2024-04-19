using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasDesignPageBatchqueryResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasDesignPageBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 承载页列表
        /// </summary>
        [XmlArray("page_list")]
        [XmlArrayItem("page_info_d_t_o")]
        public List<PageInfoDTO> PageList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询总量
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
