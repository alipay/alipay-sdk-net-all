using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunOssCorsModifyResponse.
    /// </summary>
    public class AlipayCloudCloudrunOssCorsModifyResponse : AopResponse
    {
        /// <summary>
        /// 跨域配置
        /// </summary>
        [XmlElement("cors")]
        public CorsSetting Cors { get; set; }
    }
}
