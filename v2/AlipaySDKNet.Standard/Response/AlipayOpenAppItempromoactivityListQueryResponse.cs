using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppItempromoactivityListQueryResponse.
    /// </summary>
    public class AlipayOpenAppItempromoactivityListQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品基础信息
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("promo_activity_item_page_v_o")]
        public List<PromoActivityItemPageVO> Data { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 营销活动类型
        /// </summary>
        [XmlElement("promotion_type")]
        public string PromotionType { get; set; }

        /// <summary>
        /// 营销活动名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_number")]
        public long TotalNumber { get; set; }
    }
}
