using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// TechriskRiskaiOpsgptTaskQueryResponse.
    /// </summary>
    public class TechriskRiskaiOpsgptTaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 模型输出的结果响应。
        /// </summary>
        [XmlElement("response")]
        public ResponseMsg Response { get; set; }
    }
}
