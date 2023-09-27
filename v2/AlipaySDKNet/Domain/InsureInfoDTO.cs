using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsureInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsureInfoDTO : AopObject
    {
        /// <summary>
        /// 投保渠道（直接投保必选）
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 事件类型（直接投保必选)
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 员工工种信息（直接投模式必选）
        /// </summary>
        [XmlElement("job")]
        public string Job { get; set; }

        /// <summary>
        /// 职业级别。 第一级：1 第二级：2 ... （直接投模式必选）
        /// </summary>
        [XmlElement("job_level")]
        public string JobLevel { get; set; }

        /// <summary>
        /// 外部员工id
        /// </summary>
        [XmlElement("out_employee_id")]
        public string OutEmployeeId { get; set; }

        /// <summary>
        /// 产品订购方案id（直接投保必选）
        /// </summary>
        [XmlElement("product_plan_id")]
        public string ProductPlanId { get; set; }

        /// <summary>
        /// 投保场景（直接投保必选）
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
