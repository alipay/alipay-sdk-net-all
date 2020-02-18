using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SealPageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SealPageInfo : AopObject
    {
        /// <summary>
        /// 当前页码号
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 当前页码的用印申请信息
        /// </summary>
        [XmlElement("seal_request_info")]
        public SealRequestInfo SealRequestInfo { get; set; }
    }
}
