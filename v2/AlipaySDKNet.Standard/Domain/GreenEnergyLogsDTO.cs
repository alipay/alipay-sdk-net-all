using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GreenEnergyLogsDTO Data Structure.
    /// </summary>
    [Serializable]
    public class GreenEnergyLogsDTO : AopObject
    {
        /// <summary>
        /// 能量数量,单位g
        /// </summary>
        [XmlElement("energy_amount")]
        public long EnergyAmount { get; set; }

        /// <summary>
        /// 绿色行为描述文案
        /// </summary>
        [XmlElement("energy_desc")]
        public string EnergyDesc { get; set; }

        /// <summary>
        /// 能量标签
        /// </summary>
        [XmlArray("energy_tags")]
        [XmlArrayItem("string")]
        public List<string> EnergyTags { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 能量流水id
        /// </summary>
        [XmlElement("log_id")]
        public string LogId { get; set; }

        /// <summary>
        /// 能量流水产生时间
        /// </summary>
        [XmlElement("record_time")]
        public string RecordTime { get; set; }

        /// <summary>
        /// OK: 领取成功 OVER_ACTIVITY_LIMITATION: 超过活动配置限制 OVER_ENERGY_APPLY_LIMITATION: 超过能量获取限制 ACTIVITY_EXPIRED: 活动过期
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 能量领取失败的原因描述： OK：领取成功； OVER_ACTIVITY_LIMITATION：领光了，活动商品数量已达上限； ACTIVITY_EXPIRED：超过活动有效期，不可再获得能量了 OVER_ENERGY_APPLY_LIMITATION：今日能量已领完，领取次数已达上限
        /// </summary>
        [XmlElement("result_message")]
        public string ResultMessage { get; set; }

        /// <summary>
        /// 能量状态：  0.待领取；1.已领取. 2.领取失败
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
