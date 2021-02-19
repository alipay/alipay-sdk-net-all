using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwTreeBatchqueryResponse.
    /// </summary>
    public class AlipayIserviceCcmSwTreeBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 类目集合
        /// </summary>
        [XmlElement("trees")]
        public TreeInfo Trees { get; set; }
    }
}
