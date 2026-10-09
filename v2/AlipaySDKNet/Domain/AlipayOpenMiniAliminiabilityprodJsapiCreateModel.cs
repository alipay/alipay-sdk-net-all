using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAliminiabilityprodJsapiCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAliminiabilityprodJsapiCreateModel : AopObject
    {
        /// <summary>
        /// api基本参数
        /// </summary>
        [XmlElement("api_base_request")]
        public JsApiBaseDTO ApiBaseRequest { get; set; }

        /// <summary>
        /// JsApi错误码
        /// </summary>
        [XmlArray("api_error_code_request")]
        [XmlArrayItem("error_code_d_t_o")]
        public List<ErrorCodeDTO> ApiErrorCodeRequest { get; set; }

        /// <summary>
        /// 入参列表
        /// </summary>
        [XmlElement("in_param_requests")]
        public string InParamRequests { get; set; }

        /// <summary>
        /// 出参
        /// </summary>
        [XmlElement("out_param_requests")]
        public string OutParamRequests { get; set; }
    }
}
