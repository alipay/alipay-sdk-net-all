using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringItemlistQueryResponse.
    /// </summary>
    public class KoubeiCateringItemlistQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品摘要信息列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("cater_item_list_info")]
        public List<CaterItemListInfo> ItemList { get; set; }

        /// <summary>
        /// 请求id。支持英文字母和数字，由开发者自行定义（不允许重复）
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 当前可查询商品总条目数
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }
    }
}
