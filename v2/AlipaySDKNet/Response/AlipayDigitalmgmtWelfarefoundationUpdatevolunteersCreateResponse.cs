using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtWelfarefoundationUpdatevolunteersCreateResponse.
    /// </summary>
    public class AlipayDigitalmgmtWelfarefoundationUpdatevolunteersCreateResponse : AopResponse
    {
        /// <summary>
        /// 操作结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
