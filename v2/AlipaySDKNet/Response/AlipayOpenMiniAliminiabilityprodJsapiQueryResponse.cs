using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniAliminiabilityprodJsapiQueryResponse.
    /// </summary>
    public class AlipayOpenMiniAliminiabilityprodJsapiQueryResponse : AopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlArray("error_code_dto_list")]
        [XmlArrayItem("error_code_d_t_o")]
        public List<ErrorCodeDTO> ErrorCodeDtoList { get; set; }

        /// <summary>
        /// 入参
        /// </summary>
        [XmlElement("in_params")]
        public string InParams { get; set; }

        /// <summary>
        /// JSAPI基础参数
        /// </summary>
        [XmlElement("js_api_base_dto")]
        public JsApiBaseDTO JsApiBaseDto { get; set; }

        /// <summary>
        /// 出参
        /// </summary>
        [XmlElement("out_params")]
        public string OutParams { get; set; }
    }
}
