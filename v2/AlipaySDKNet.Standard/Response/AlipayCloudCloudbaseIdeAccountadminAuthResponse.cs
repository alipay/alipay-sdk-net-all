using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseIdeAccountadminAuthResponse.
    /// </summary>
    public class AlipayCloudCloudbaseIdeAccountadminAuthResponse : AopResponse
    {
        /// <summary>
        /// 授权结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
