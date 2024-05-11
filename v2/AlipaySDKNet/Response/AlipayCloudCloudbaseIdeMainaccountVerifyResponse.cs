using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseIdeMainaccountVerifyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseIdeMainaccountVerifyResponse : AopResponse
    {
        /// <summary>
        /// 校验结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
