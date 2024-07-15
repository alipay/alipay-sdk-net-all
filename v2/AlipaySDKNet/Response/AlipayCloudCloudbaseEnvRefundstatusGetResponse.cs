using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvRefundstatusGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseEnvRefundstatusGetResponse : AopResponse
    {
        /// <summary>
        /// 环境销毁是否需要退费
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
