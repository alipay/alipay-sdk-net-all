using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MarketingPartnerShip Data Structure.
    /// </summary>
    [Serializable]
    public class MarketingPartnerShip : AopObject
    {
        /// <summary>
        /// 被授权数据
        /// </summary>
        [XmlElement("authorized_data")]
        public MarketingAuthorizedData AuthorizedData { get; set; }

        /// <summary>
        /// 建立合作关系的时间。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 合作方相关信息
        /// </summary>
        [XmlElement("partner")]
        public MarketingPartner Partner { get; set; }

        /// <summary>
        /// 合作状态 枚举值：  ESTABLISHED：已建立  TERMINATED：已终止
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 终止合作关系时间。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("stop_time")]
        public string StopTime { get; set; }
    }
}
