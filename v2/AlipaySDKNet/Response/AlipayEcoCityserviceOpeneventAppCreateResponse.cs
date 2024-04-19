using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoCityserviceOpeneventAppCreateResponse.
    /// </summary>
    public class AlipayEcoCityserviceOpeneventAppCreateResponse : AopResponse
    {
        /// <summary>
        /// 服务入驻后在光华平台的唯一标识，可以通过该标识进行服务的信息变更和状态变更。报错的情况下该字段没有值
        /// </summary>
        [XmlElement("app_code")]
        public string AppCode { get; set; }
    }
}
