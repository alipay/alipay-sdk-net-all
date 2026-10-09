using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeviceServiceBaseVO Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceServiceBaseVO : AopObject
    {
        /// <summary>
        /// 设备别名
        /// </summary>
        [XmlElement("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 节点类型 0为网关设备。1.为mesh子设备。2为除网关类的其他直连设备。3为外设
        /// </summary>
        [XmlElement("node_type")]
        public long NodeType { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 设备在线状态 0为离线。1为在线
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// xpId
        /// </summary>
        [XmlElement("xp_id")]
        public string XpId { get; set; }
    }
}
