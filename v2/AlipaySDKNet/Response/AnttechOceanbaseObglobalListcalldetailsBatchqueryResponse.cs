using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalListcalldetailsBatchqueryResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalListcalldetailsBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 业务错误码
        /// </summary>
        [XmlElement("biz_error_code")]
        public string BizErrorCode { get; set; }

        /// <summary>
        /// 业务错误信息
        /// </summary>
        [XmlElement("biz_error_msg")]
        public string BizErrorMsg { get; set; }

        /// <summary>
        /// 业务是否成功
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 历史通话详情列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("call_detail_d_t_o")]
        public List<CallDetailDTO> Result { get; set; }

        /// <summary>
        /// 记录总数，current_page为1时返回真实记录总数，其他时候返回0
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
