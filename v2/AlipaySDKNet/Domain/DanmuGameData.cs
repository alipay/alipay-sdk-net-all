using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DanmuGameData Data Structure.
    /// </summary>
    [Serializable]
    public class DanmuGameData : AopObject
    {
        /// <summary>
        /// 评论内容
        /// </summary>
        [XmlArray("content")]
        [XmlArrayItem("string")]
        public List<string> Content { get; set; }

        /// <summary>
        /// 评论内容数组形式 当前字段已废弃(废弃改参数，content字段就是string数组)
        /// </summary>
        [XmlArray("content_list")]
        [XmlArrayItem("string")]
        public List<string> ContentList { get; set; }

        /// <summary>
        /// 点赞数量，单位个
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 礼物数量，单位个
        /// </summary>
        [XmlElement("gift_count")]
        public long GiftCount { get; set; }

        /// <summary>
        /// 礼物id
        /// </summary>
        [XmlElement("gift_id")]
        public string GiftId { get; set; }

        /// <summary>
        /// 礼物名称
        /// </summary>
        [XmlElement("gift_name")]
        public string GiftName { get; set; }

        /// <summary>
        /// 礼物总价值，单位钻石（1元=10钻石）
        /// </summary>
        [XmlElement("gift_total_price")]
        public long GiftTotalPrice { get; set; }

        /// <summary>
        /// 礼物单价，单位钻石（1元=10钻石）
        /// </summary>
        [XmlElement("gift_unit_price")]
        public long GiftUnitPrice { get; set; }

        /// <summary>
        /// 用户头像url
        /// </summary>
        [XmlElement("head_url")]
        public string HeadUrl { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 单号，一个单号代表一笔送收礼, 幂等消费
        /// </summary>
        [XmlElement("unique_no")]
        public string UniqueNo { get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        [XmlElement("user_info")]
        public DanmuGameUserInfo UserInfo { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
