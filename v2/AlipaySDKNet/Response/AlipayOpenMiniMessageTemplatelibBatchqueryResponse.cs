using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniMessageTemplatelibBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniMessageTemplatelibBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 分页页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小，规定最大分页大小为10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 消息模板库列表
        /// </summary>
        [XmlArray("template_lib_list")]
        [XmlArrayItem("merchant_msg_template_lib_v_o")]
        public List<MerchantMsgTemplateLibVO> TemplateLibList { get; set; }

        /// <summary>
        /// 查询结果总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
