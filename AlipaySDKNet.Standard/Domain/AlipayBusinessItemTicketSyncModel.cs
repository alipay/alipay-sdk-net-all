using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBusinessItemTicketSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessItemTicketSyncModel : AopObject
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("scenic_ext_info")]
        public List<ScenicExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 门票名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 表示景区的id
        /// </summary>
        [XmlElement("outer_scenic_id")]
        public string OuterScenicId { get; set; }

        /// <summary>
        /// 门票商品id
        /// </summary>
        [XmlElement("outer_ticket_id")]
        public string OuterTicketId { get; set; }

        /// <summary>
        /// 商户userId
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        [XmlElement("pic")]
        public string Pic { get; set; }

        /// <summary>
        /// 景区小程序id
        /// </summary>
        [XmlElement("scenic_app_id")]
        public string ScenicAppId { get; set; }

        /// <summary>
        /// 服务商名称
        /// </summary>
        [XmlElement("source_system")]
        public string SourceSystem { get; set; }

        /// <summary>
        /// 0：无效 1：有效
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 商品在支付宝内的id
        /// </summary>
        [XmlElement("ticket_goods_id")]
        public string TicketGoodsId { get; set; }

        /// <summary>
        /// 支付宝小程序的商品页面链接
        /// </summary>
        [XmlElement("ticket_link")]
        public string TicketLink { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("ticket_modified_time")]
        public string TicketModifiedTime { get; set; }

        /// <summary>
        /// 门票规格列表
        /// </summary>
        [XmlArray("ticket_specs")]
        [XmlArrayItem("string")]
        public List<string> TicketSpecs { get; set; }

        /// <summary>
        /// 门票类型 NORMAL("NORMAL","普通"), GROUP("GROUP","套票"), PERIOD("PERIOD","时段票"), REGION("REGION","区域票")
        /// </summary>
        [XmlElement("ticket_type")]
        public string TicketType { get; set; }

        /// <summary>
        /// 更新信息
        /// </summary>
        [XmlElement("update_msg")]
        public string UpdateMsg { get; set; }
    }
}
