using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvAkModifyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseEnvAkModifyResponse : AopResponse
    {
        /// <summary>
        /// 修改ak结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
