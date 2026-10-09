using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpaccessBindModifyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseHttpaccessBindModifyResponse : AopResponse
    {
        /// <summary>
        /// 是否修改成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
