using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceAnthotlinemngCalldetailBatchqueryResponse.
    /// </summary>
    public class AlipayIserviceAnthotlinemngCalldetailBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前分页页码
        /// </summary>
        [XmlElement("current")]
        public long Current { get; set; }

        /// <summary>
        /// 通话详情列表数据
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("call_detail")]
        public List<CallDetail> List { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数，只有PageNum为1才会返回真实数值，其他都是0。
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }

        /// <summary>
        /// 总页数，只有PageNum为1才会返回真实数值，其他都是0。
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }
    }
}
