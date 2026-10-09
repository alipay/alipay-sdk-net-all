using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvAkDeleteResponse.
    /// </summary>
    public class AlipayCloudCloudbaseEnvAkDeleteResponse : AopResponse
    {
        /// <summary>
        /// 删除ak结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
