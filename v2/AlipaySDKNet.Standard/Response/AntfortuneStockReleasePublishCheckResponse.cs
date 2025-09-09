using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneStockReleasePublishCheckResponse.
    /// </summary>
    public class AntfortuneStockReleasePublishCheckResponse : AopResponse
    {
        /// <summary>
        /// 返回本次发布的校验结果
        /// </summary>
        [XmlElement("publish_able")]
        public bool PublishAble { get; set; }
    }
}
