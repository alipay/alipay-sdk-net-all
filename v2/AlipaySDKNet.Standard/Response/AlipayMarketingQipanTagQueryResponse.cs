using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingQipanTagQueryResponse.
    /// </summary>
    public class AlipayMarketingQipanTagQueryResponse : AopResponse
    {
        /// <summary>
        /// 圈选标签的圈选项、圈选值详情，创建标签圈选请求时，需要传入每个圈选项对应的圈选值
        /// </summary>
        [XmlElement("operation_tag")]
        public OpenCrowdOperationTag OperationTag { get; set; }
    }
}
