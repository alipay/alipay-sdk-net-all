using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateManagerInfoBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEducateManagerInfoBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 管理员列表
        /// </summary>
        [XmlArray("manager_list")]
        [XmlArrayItem("edu_manager_info")]
        public List<EduManagerInfo> ManagerList { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}
