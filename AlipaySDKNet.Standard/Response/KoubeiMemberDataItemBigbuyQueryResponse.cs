using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMemberDataItemBigbuyQueryResponse.
    /// </summary>
    public class KoubeiMemberDataItemBigbuyQueryResponse : AopResponse
    {
        /// <summary>
        /// 超值抢购商品信息
        /// </summary>
        [XmlArray("big_buy_item_list")]
        [XmlArrayItem("index_bigbuy_item")]
        public List<IndexBigbuyItem> BigBuyItemList { get; set; }

        /// <summary>
        /// 当前时间
        /// </summary>
        [XmlElement("current_time")]
        public long CurrentTime { get; set; }

        /// <summary>
        /// 排期结束时间
        /// </summary>
        [XmlElement("gmt_end")]
        public long GmtEnd { get; set; }

        /// <summary>
        /// 排期开始时间
        /// </summary>
        [XmlElement("gmt_start")]
        public long GmtStart { get; set; }

        /// <summary>
        /// 营销展位码，如果运营配置了对应的展位码并且这些展位码能够查询到推按信息的话第一个会展示此展位码
        /// </summary>
        [XmlElement("index_block_banner")]
        public IndexBlockBanner IndexBlockBanner { get; set; }

        /// <summary>
        /// 区块跳转链接
        /// </summary>
        [XmlElement("promo_schema")]
        public string PromoSchema { get; set; }
    }
}
