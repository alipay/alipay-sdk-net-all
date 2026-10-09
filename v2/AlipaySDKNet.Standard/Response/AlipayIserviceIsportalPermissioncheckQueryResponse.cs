using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIsportalPermissioncheckQueryResponse.
    /// </summary>
    public class AlipayIserviceIsportalPermissioncheckQueryResponse : AopResponse
    {
        /// <summary>
        /// 鉴权结果
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }
    }
}
