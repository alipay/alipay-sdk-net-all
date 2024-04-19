using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceMindvAnswersBatchqueryResponse.
    /// </summary>
    public class AlipayIserviceMindvAnswersBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前分页码_和入参保持一致
        /// </summary>
        [XmlElement("current_page_num")]
        public long CurrentPageNum { get; set; }

        /// <summary>
        /// 用户提交结果数据
        /// </summary>
        [XmlArray("page_data")]
        [XmlArrayItem("user_submit_model")]
        public List<UserSubmitModel> PageData { get; set; }

        /// <summary>
        /// 每页数量限制_和入参保持一致
        /// </summary>
        [XmlElement("per_page_size")]
        public long PerPageSize { get; set; }

        /// <summary>
        /// 总的数据数量_提供给业务方自行判断是否继续查询后续数据
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}
