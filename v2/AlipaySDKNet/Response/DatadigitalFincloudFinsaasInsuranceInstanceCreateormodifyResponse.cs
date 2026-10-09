using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasInsuranceInstanceCreateormodifyResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasInsuranceInstanceCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// result_code不唯一，表示服务指令的执行结果
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
