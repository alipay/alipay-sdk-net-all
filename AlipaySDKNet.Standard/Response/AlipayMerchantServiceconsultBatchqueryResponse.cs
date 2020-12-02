using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantServiceconsultBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantServiceconsultBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 服务咨询工单列表信息
        /// </summary>
        [XmlArray("consult_infos")]
        [XmlArrayItem("service_consult_query_response")]
        public List<ServiceConsultQueryResponse> ConsultInfos { get; set; }

        /// <summary>
        /// 当前页码数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }

        /// <summary>
        /// 总页码数
        /// </summary>
        [XmlElement("total_page_num")]
        public long TotalPageNum { get; set; }
    }
}
