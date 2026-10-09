using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NCardAdvertiseTask Data Structure.
    /// </summary>
    [Serializable]
    public class NCardAdvertiseTask : AopObject
    {
        /// <summary>
        /// 广告媒体类型
        /// </summary>
        [XmlElement("advertise_type")]
        public string AdvertiseType { get; set; }

        /// <summary>
        /// 线圈在这个点位安装的具体位置
        /// </summary>
        [XmlElement("card_install_location")]
        public string CardInstallLocation { get; set; }

        /// <summary>
        /// 作业人员脱敏名称
        /// </summary>
        [XmlElement("desens_staff_name")]
        public string DesensStaffName { get; set; }

        /// <summary>
        /// 某个海报点位的唯一id
        /// </summary>
        [XmlElement("position_id")]
        public string PositionId { get; set; }

        /// <summary>
        /// 对应一个作业单、线圈的所在位置
        /// </summary>
        [XmlElement("position_name")]
        public string PositionName { get; set; }

        /// <summary>
        /// 说明当前点位作业状态，完成绑定、验证、审核通过则算作业完成
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 线圈唯一业务标识
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }

        /// <summary>
        /// 作业单唯一id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 作业完成时间，只有完成作业单才有，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("work_end_time")]
        public string WorkEndTime { get; set; }

        /// <summary>
        /// 进入作业状态后，开始作业的时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("work_start_time")]
        public string WorkStartTime { get; set; }
    }
}
