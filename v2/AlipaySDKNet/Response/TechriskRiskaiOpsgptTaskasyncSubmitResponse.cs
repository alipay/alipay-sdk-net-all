using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// TechriskRiskaiOpsgptTaskasyncSubmitResponse.
    /// </summary>
    public class TechriskRiskaiOpsgptTaskasyncSubmitResponse : AopResponse
    {
        /// <summary>
        /// 返回任务提交的结果，主要是任务id，用于后续用户使用该id情况
        /// </summary>
        [XmlElement("response")]
        public AsyncSubmitTaskResponse Response { get; set; }
    }
}
