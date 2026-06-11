using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderExpoCheckplaceCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderExpoCheckplaceCreateModel : AopObject
    {
        /// <summary>
        /// 活动code
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 卡面破形底图URL
        /// </summary>
        [XmlElement("card_edge_bg_image")]
        public string CardEdgeBgImage { get; set; }

        /// <summary>
        /// 卡面破形图URL
        /// </summary>
        [XmlElement("card_edge_image")]
        public string CardEdgeImage { get; set; }

        /// <summary>
        /// 卡片名称
        /// </summary>
        [XmlElement("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 卡面底图URL
        /// </summary>
        [XmlElement("card_url")]
        public string CardUrl { get; set; }

        /// <summary>
        /// 打卡点类型：pay=支付，simple=普通
        /// </summary>
        [XmlElement("check_place_type")]
        public string CheckPlaceType { get; set; }

        /// <summary>
        /// 设备SN，pay类型必填，多个SN用英文逗号分隔
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 自定义打卡点标记（活动下唯一）
        /// </summary>
        [XmlElement("external_place_mark")]
        public string ExternalPlaceMark { get; set; }

        /// <summary>
        /// 打卡点名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 关联业务id
        /// </summary>
        [XmlElement("rel_biz_id")]
        public string RelBizId { get; set; }

        /// <summary>
        /// 关联业务类型
        /// </summary>
        [XmlElement("rel_biz_type")]
        public string RelBizType { get; set; }
    }
}
