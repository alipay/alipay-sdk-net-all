using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalBailingualCreateResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalBailingualCreateResponse : AopResponse
    {
        /// <summary>
        /// 在百灵创建文案接口的返回对象
        /// </summary>
        [XmlElement("create_text_params_response")]
        public CreateTextParamsResponse CreateTextParamsResponse { get; set; }
    }
}
