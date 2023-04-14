using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceDataScenicExplanationSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceDataScenicExplanationSyncModel : AopObject
    {
        /// <summary>
        /// 该景区的小程序appid。
        /// </summary>
        [XmlElement("scenic_app_id")]
        public string ScenicAppId { get; set; }

        /// <summary>
        /// 商户（或ISV）系统内的景区id。
        /// </summary>
        [XmlElement("scenic_outer_id")]
        public string ScenicOuterId { get; set; }

        /// <summary>
        /// 商户（或ISV）系统内的讲解点。
        /// </summary>
        [XmlArray("scenic_points")]
        [XmlArrayItem("scenic_explanation_point")]
        public List<ScenicExplanationPoint> ScenicPoints { get; set; }

        /// <summary>
        /// 该景区订购的语音讲解的插件Appid。
        /// </summary>
        [XmlElement("service_plugin_id")]
        public string ServicePluginId { get; set; }
    }
}
