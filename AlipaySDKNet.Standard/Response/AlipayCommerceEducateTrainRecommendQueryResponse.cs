using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateTrainRecommendQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateTrainRecommendQueryResponse : AopResponse
    {
        /// <summary>
        /// 根据年龄推荐的学段
        /// </summary>
        [XmlElement("default_first_cate")]
        public CateInfoVO DefaultFirstCate { get; set; }

        /// <summary>
        /// 是否有更多
        /// </summary>
        [XmlElement("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 推荐元素列表
        /// </summary>
        [XmlArray("item_infos")]
        [XmlArrayItem("item_info_v_o")]
        public List<ItemInfoVO> ItemInfos { get; set; }

        /// <summary>
        /// 外部场景传入的学段
        /// </summary>
        [XmlElement("selected_first_cate")]
        public CateInfoVO SelectedFirstCate { get; set; }
    }
}
