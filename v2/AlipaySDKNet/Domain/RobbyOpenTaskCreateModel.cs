using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RobbyOpenTaskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class RobbyOpenTaskCreateModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("biz_info_list")]
        [XmlArrayItem("biz_info_map")]
        public List<BizInfoMap> BizInfoList { get; set; }

        /// <summary>
        /// 业务编号，如用户侧订单编号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 扩展信息，附属的其他信息
        /// </summary>
        [XmlElement("ext_info")]
        public OtherInfo ExtInfo { get; set; }

        /// <summary>
        /// 场景类型，根据自己的业务类型填值，具体查看枚举值
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 机器人编号
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 子业务编号，全局唯一，如用户侧订单有多个批次，批次号是当前订单的子业务编号
        /// </summary>
        [XmlElement("sub_biz_no")]
        public string SubBizNo { get; set; }

        /// <summary>
        /// 目标点
        /// </summary>
        [XmlElement("target_point")]
        public TargetPoint TargetPoint { get; set; }

        /// <summary>
        /// 任务类型，根据自己的业务类型填值，如 PICK_UP
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }

        /// <summary>
        /// 任务执行超时时间，超过此设置的超时时间未执行成功即为执行失败，单位：秒
        /// </summary>
        [XmlElement("time_out")]
        public long TimeOut { get; set; }
    }
}
