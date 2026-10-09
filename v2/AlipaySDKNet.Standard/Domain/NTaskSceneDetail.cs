using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NTaskSceneDetail Data Structure.
    /// </summary>
    [Serializable]
    public class NTaskSceneDetail : AopObject
    {
        /// <summary>
        /// 点位绑定资产id，线圈作业场景为tagId，设备作业场景为sn
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 状态的变更时间
        /// </summary>
        [XmlElement("modify_time")]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 操作人未脱敏支付宝登记的电话号码
        /// </summary>
        [XmlElement("operator_contact_number")]
        public string OperatorContactNumber { get; set; }

        /// <summary>
        /// 操作人未脱敏名称
        /// </summary>
        [XmlElement("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 点位id
        /// </summary>
        [XmlElement("position_id")]
        public string PositionId { get; set; }

        /// <summary>
        /// 关联绑定资产id，设备作业场景使用
        /// </summary>
        [XmlElement("related_device_id")]
        public string RelatedDeviceId { get; set; }

        /// <summary>
        /// 绑定状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 操作标识，绑定类型消息时为作业单据id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
