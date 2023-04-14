using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditProdarrangementContracttextQueryResponse.
    /// </summary>
    public class MybankCreditProdarrangementContracttextQueryResponse : AopResponse
    {
        /// <summary>
        /// 合同内容
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
