using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpaccessBindCreateResponse.
    /// </summary>
    public class AlipayCloudCloudbaseHttpaccessBindCreateResponse : AopResponse
    {
        /// <summary>
        /// 是否绑定成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
