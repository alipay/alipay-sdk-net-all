using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasCrowdListBatchqueryResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasCrowdListBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 人群信息列表
        /// </summary>
        [XmlArray("crowd_list")]
        [XmlArrayItem("crowd_info_d_t_o")]
        public List<CrowdInfoDTO> CrowdList { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 人群总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
