using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SiteStrategy Data Structure.
    /// </summary>
    [Serializable]
    public class SiteStrategy : AopObject
    {
        /// <summary>
        /// 点位距离，单位km
        /// </summary>
        [XmlElement("distance")]
        public long Distance { get; set; }

        /// <summary>
        /// 市场屏投放类型 0-自投 1-互投
        /// </summary>
        [XmlElement("market_screen_biz_type")]
        public long MarketScreenBizType { get; set; }

        /// <summary>
        /// 点位数量
        /// </summary>
        [XmlElement("site_num")]
        public long SiteNum { get; set; }

        /// <summary>
        /// 互投场景下的指定不投放的点位列表（如自家屏幕），如果为空，投放点位不做限制
        /// </summary>
        [XmlArray("sn_black_list")]
        [XmlArrayItem("string")]
        public List<string> SnBlackList { get; set; }

        /// <summary>
        /// 自投场景下的指定投放的点位列表，如果为空，投放点位不做限制
        /// </summary>
        [XmlArray("sn_white_list")]
        [XmlArrayItem("string")]
        public List<string> SnWhiteList { get; set; }
    }
}
