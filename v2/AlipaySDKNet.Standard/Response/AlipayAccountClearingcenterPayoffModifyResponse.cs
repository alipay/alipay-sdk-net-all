using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAccountClearingcenterPayoffModifyResponse.
    /// </summary>
    public class AlipayAccountClearingcenterPayoffModifyResponse : AopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public ClearingCommonResult Result { get; set; }
    }
}
