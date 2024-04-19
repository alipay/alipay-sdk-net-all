using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasPutplanQueryResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasPutplanQueryResponse : AopResponse
    {
        /// <summary>
        /// 投放计划详情对象
        /// </summary>
        [XmlElement("detail")]
        public ChannelPutPlanDetailDTO Detail { get; set; }
    }
}
