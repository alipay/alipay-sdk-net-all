using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseMarketStudentApplyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseMarketStudentApplyResponse : AopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
