using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdentitylibraryServiceentityBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdentitylibraryServiceentityBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 实体详情信息的列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("service_entity")]
        public List<ServiceEntity> List { get; set; }

        /// <summary>
        /// 返回的分页信息
        /// </summary>
        [XmlElement("pagination")]
        public EntityPagination Pagination { get; set; }
    }
}
