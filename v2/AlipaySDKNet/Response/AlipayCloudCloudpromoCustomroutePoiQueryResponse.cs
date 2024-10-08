using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoCustomroutePoiQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoCustomroutePoiQueryResponse : AopResponse
    {
        /// <summary>
        /// item_id 为伴游卡片唯一id
        /// </summary>
        [XmlArray("poi_tag_info_list")]
        [XmlArrayItem("poi_tag_info")]
        public List<PoiTagInfo> PoiTagInfoList { get; set; }

        /// <summary>
        /// 用户已经选择的景点id列表
        /// </summary>
        [XmlArray("selected_item_id_list")]
        [XmlArrayItem("string")]
        public List<string> SelectedItemIdList { get; set; }
    }
}
