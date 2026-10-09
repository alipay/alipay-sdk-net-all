using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseChatGmemberDeleteResponse.
    /// </summary>
    public class AlipaySocialBaseChatGmemberDeleteResponse : AopResponse
    {
        /// <summary>
        /// 删除结果
        /// </summary>
        [XmlElement("result_delete")]
        public bool ResultDelete { get; set; }
    }
}
