using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceVoucherTemplateQueryResponse.
    /// </summary>
    public class AlipayCommerceVoucherTemplateQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页数
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }

        /// <summary>
        /// 券模板列表
        /// </summary>
        [XmlArray("voucher_template_list")]
        [XmlArrayItem("yun_task_voucher_template_info")]
        public List<YunTaskVoucherTemplateInfo> VoucherTemplateList { get; set; }
    }
}
