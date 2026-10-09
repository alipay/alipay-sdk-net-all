using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommonTaskinstanceBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceCommonTaskinstanceBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 分页页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 任务实例信息列表
        /// </summary>
        [XmlArray("task_info_list")]
        [XmlArrayItem("task_instance_basic_info_d_t_o")]
        public List<TaskInstanceBasicInfoDTO> TaskInfoList { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
