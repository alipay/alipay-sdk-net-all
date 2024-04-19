using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtHrcampuscoreEntrySyncResponse.
    /// </summary>
    public class AlipayDigitalmgmtHrcampuscoreEntrySyncResponse : AopResponse
    {
        /// <summary>
        /// 入职表单号
        /// </summary>
        [XmlElement("form_no")]
        public string FormNo { get; set; }
    }
}
