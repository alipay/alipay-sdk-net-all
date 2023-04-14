using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseChatGnoticeModifyResponse.
    /// </summary>
    public class AlipaySocialBaseChatGnoticeModifyResponse : AopResponse
    {
        /// <summary>
        /// 修改结果
        /// </summary>
        [XmlElement("result_modify")]
        public string ResultModify { get; set; }
    }
}
