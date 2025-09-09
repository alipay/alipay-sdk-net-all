using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvRefundResponse.
    /// </summary>
    public class AlipayCloudCloudbaseEnvRefundResponse : AopResponse
    {
        /// <summary>
        /// 销毁并退费操作结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
