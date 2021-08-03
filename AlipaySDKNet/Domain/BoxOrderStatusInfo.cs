using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BoxOrderStatusInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BoxOrderStatusInfo : AopObject
    {
        /// <summary>
        /// 工单数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 工单id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 最新工单状态
        /// </summary>
        [XmlElement("latest_status")]
        public string LatestStatus { get; set; }
    }
}
