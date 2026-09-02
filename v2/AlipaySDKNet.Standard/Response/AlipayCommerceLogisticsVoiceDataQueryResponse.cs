using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsVoiceDataQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsVoiceDataQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页最大数据ID，用于翻页
        /// </summary>
        [XmlElement("cur_page_max_data_id")]
        public string CurPageMaxDataId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("logistics_voice_scene_data")]
        public List<LogisticsVoiceSceneData> DataList { get; set; }

        /// <summary>
        /// 是否有更多数据
        /// </summary>
        [XmlElement("has_more")]
        public string HasMore { get; set; }
    }
}
