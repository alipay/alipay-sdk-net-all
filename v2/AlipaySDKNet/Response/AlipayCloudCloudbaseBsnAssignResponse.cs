using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseBsnAssignResponse.
    /// </summary>
    public class AlipayCloudCloudbaseBsnAssignResponse : AopResponse
    {
        /// <summary>
        /// 授权结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
