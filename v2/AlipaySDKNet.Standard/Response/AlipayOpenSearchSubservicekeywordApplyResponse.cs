using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSearchSubservicekeywordApplyResponse.
    /// </summary>
    public class AlipayOpenSearchSubservicekeywordApplyResponse : AopResponse
    {
        /// <summary>
        /// 审核工单id，唯一，提报服务关键词，提报服务关键词返回该id
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }
    }
}
