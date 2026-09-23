using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalAicsDevinWorkGetResponse.
    /// </summary>
    public class DatadigitalAicsDevinWorkGetResponse : AopResponse
    {
        /// <summary>
        /// 数字员工详情，variables 为该数字人话术中引用的模板变量Code列表
        /// </summary>
        [XmlElement("data")]
        public WorkerGetDetailData Data { get; set; }
    }
}
