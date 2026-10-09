using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommonTasktemplateBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceCommonTasktemplateBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 任务模板信息列表
        /// </summary>
        [XmlArray("task_list")]
        [XmlArrayItem("tao_ke_task_template_info_d_t_o")]
        public List<TaoKeTaskTemplateInfoDTO> TaskList { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}
