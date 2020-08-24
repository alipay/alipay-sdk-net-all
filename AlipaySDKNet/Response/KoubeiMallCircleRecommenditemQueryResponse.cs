using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMallCircleRecommenditemQueryResponse.
    /// </summary>
    public class KoubeiMallCircleRecommenditemQueryResponse : AopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误文案
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 是否有更多商品； true：下一页有商品 false：下一页无商品
        /// </summary>
        [XmlElement("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 下一页起始查询值
        /// </summary>
        [XmlElement("next_start")]
        public long NextStart { get; set; }

        /// <summary>
        /// 每页查询量，分页长度
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 生活圈推荐商品信息模型
        /// </summary>
        [XmlArray("recommend_item")]
        [XmlArrayItem("circle_recommend_item_d_t_o")]
        public List<CircleRecommendItemDTO> RecommendItem { get; set; }

        /// <summary>
        /// 业务请求成功与否; true：成功  false：失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
