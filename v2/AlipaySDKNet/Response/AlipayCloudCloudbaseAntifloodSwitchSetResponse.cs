using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseAntifloodSwitchSetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseAntifloodSwitchSetResponse : AopResponse
    {
        /// <summary>
        /// 设置结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
