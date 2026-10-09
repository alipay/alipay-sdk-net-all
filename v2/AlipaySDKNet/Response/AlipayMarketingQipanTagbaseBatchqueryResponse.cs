using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingQipanTagbaseBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingQipanTagbaseBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 返回全部可用的圈选标签基本信息。
        /// </summary>
        [XmlArray("operation_tag_list")]
        [XmlArrayItem("open_crowd_operation_tag")]
        public List<OpenCrowdOperationTag> OperationTagList { get; set; }
    }
}
