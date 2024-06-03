using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseMiniappMainaccountVerifyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseMiniappMainaccountVerifyResponse : AopResponse
    {
        /// <summary>
        /// 校验结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
