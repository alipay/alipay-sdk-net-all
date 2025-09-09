using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoDocumentSegmentDeleteResponse.
    /// </summary>
    public class AlipayCloudCloudpromoDocumentSegmentDeleteResponse : AopResponse
    {
        /// <summary>
        /// 成功删除分段数目
        /// </summary>
        [XmlElement("delete_num")]
        public long DeleteNum { get; set; }
    }
}
