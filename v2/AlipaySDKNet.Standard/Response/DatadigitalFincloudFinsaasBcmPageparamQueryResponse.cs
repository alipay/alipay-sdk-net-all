using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasBcmPageparamQueryResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasBcmPageparamQueryResponse : AopResponse
    {
        /// <summary>
        /// 页面阶段所需的参数
        /// </summary>
        [XmlElement("page_param_json")]
        public string PageParamJson { get; set; }
    }
}
