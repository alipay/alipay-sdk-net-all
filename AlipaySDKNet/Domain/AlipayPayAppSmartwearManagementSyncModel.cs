using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayAppSmartwearManagementSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayAppSmartwearManagementSyncModel : AopObject
    {
        /// <summary>
        /// 具体的子操作类型
        /// </summary>
        [XmlElement("command")]
        public string Command { get; set; }

        /// <summary>
        /// 业务信息
        /// </summary>
        [XmlElement("payload")]
        public string Payload { get; set; }
    }
}
