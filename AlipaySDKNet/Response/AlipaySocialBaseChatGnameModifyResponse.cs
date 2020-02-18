using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseChatGnameModifyResponse.
    /// </summary>
    public class AlipaySocialBaseChatGnameModifyResponse : AopResponse
    {
        /// <summary>
        /// 修改结果
        /// </summary>
        [XmlElement("result_modify")]
        public bool ResultModify { get; set; }
    }
}
