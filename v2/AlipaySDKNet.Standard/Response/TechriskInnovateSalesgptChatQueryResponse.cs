using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// TechriskInnovateSalesgptChatQueryResponse.
    /// </summary>
    public class TechriskInnovateSalesgptChatQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询结果，需要接入方优化使用
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
