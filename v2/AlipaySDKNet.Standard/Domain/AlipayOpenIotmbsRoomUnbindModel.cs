using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsRoomUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsRoomUnbindModel : AopObject
    {
        /// <summary>
        /// 设备激活ID
        /// </summary>
        [XmlElement("dev_id")]
        public string DevId { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }
    }
}
