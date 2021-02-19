using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingIotBoothQueryResponse.
    /// </summary>
    public class AlipayMarketingIotBoothQueryResponse : AopResponse
    {
        /// <summary>
        /// 用于链路埋点，识别权益触发链路
        /// </summary>
        [XmlElement("booth_token")]
        public string BoothToken { get; set; }

        /// <summary>
        /// 展位结果列表
        /// </summary>
        [XmlArray("content_list")]
        [XmlArrayItem("iot_content_module_info")]
        public List<IotContentModuleInfo> ContentList { get; set; }

        /// <summary>
        /// 渲染引擎类型
        /// </summary>
        [XmlElement("engine_type")]
        public string EngineType { get; set; }
    }
}
