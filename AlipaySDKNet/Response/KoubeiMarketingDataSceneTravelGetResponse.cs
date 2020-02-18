using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingDataSceneTravelGetResponse.
    /// </summary>
    public class KoubeiMarketingDataSceneTravelGetResponse : AopResponse
    {
        /// <summary>
        /// 场景营销内容分组场景营
        /// </summary>
        [XmlArray("content")]
        [XmlArrayItem("scene_marketing_content_group")]
        public List<SceneMarketingContentGroup> Content { get; set; }

        /// <summary>
        /// 场景营销头部信息
        /// </summary>
        [XmlElement("header")]
        public SceneMarketingHeader Header { get; set; }
    }
}
