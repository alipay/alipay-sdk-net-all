using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseBsnCheckResponse.
    /// </summary>
    public class AlipayCloudCloudbaseBsnCheckResponse : AopResponse
    {
        /// <summary>
        /// 检查是否满足备案服务码申请条件结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
