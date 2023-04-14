using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsDooropenresultSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsDooropenresultSyncModel : AopObject
    {
        /// <summary>
        /// 设备激活序号
        /// </summary>
        [XmlElement("dev_id")]
        public string DevId { get; set; }

        /// <summary>
        /// 房间门状态，true为开启成功，false为开启失败
        /// </summary>
        [XmlElement("door_state")]
        public bool DoorState { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 单次刷脸开门请求全链路唯一标识
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
