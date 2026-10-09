using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvDestroyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseEnvDestroyResponse : AopResponse
    {
        /// <summary>
        /// 删除结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
