using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniOperationAppserviceQueryResponse.
    /// </summary>
    public class AlipayOpenMiniOperationAppserviceQueryResponse : AopResponse
    {
        /// <summary>
        /// 子服务列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("app_service_result")]
        public List<AppServiceResult> DataList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 该应用子服务总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
