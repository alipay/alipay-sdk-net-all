using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceFhyeduRollcallSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceFhyeduRollcallSyncModel : AopObject
    {
        /// <summary>
        /// 到课：PRESENT 迟到：LATE 未到：ABSENT 请假：LEAVE
        /// </summary>
        [XmlElement("attended_status")]
        public string AttendedStatus { get; set; }

        /// <summary>
        /// 上课开始时间
        /// </summary>
        [XmlElement("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 班级
        /// </summary>
        [XmlElement("class_name")]
        public string ClassName { get; set; }

        /// <summary>
        /// 上课教室
        /// </summary>
        [XmlElement("class_room_name")]
        public string ClassRoomName { get; set; }

        /// <summary>
        /// 预计消耗课数量
        /// </summary>
        [XmlElement("consumed_quantity")]
        public string ConsumedQuantity { get; set; }

        /// <summary>
        /// CLASS_HOUR：课时 DAY：天 MONTH：月
        /// </summary>
        [XmlElement("consumed_unit")]
        public string ConsumedUnit { get; set; }

        /// <summary>
        /// 消耗Id
        /// </summary>
        [XmlElement("consumption_target_id")]
        public string ConsumptionTargetId { get; set; }

        /// <summary>
        /// 课程名称、体验卡名称、体验卡名称
        /// </summary>
        [XmlElement("consumption_target_name")]
        public string ConsumptionTargetName { get; set; }

        /// <summary>
        /// 课程: COURSE 充值账户余额: BALANCE 体验卡: TRIAL_CARD 会员卡: MEMBERSHIP_CARD
        /// </summary>
        [XmlElement("consumption_way")]
        public string ConsumptionWay { get; set; }

        /// <summary>
        /// 上课内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 课程id
        /// </summary>
        [XmlElement("course_id")]
        public string CourseId { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        [XmlElement("course_name")]
        public string CourseName { get; set; }

        /// <summary>
        /// 上课结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 点名备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 超上数量
        /// </summary>
        [XmlElement("over_quantity")]
        public string OverQuantity { get; set; }

        /// <summary>
        /// 是否超上
        /// </summary>
        [XmlElement("over_scheduled")]
        public bool OverScheduled { get; set; }

        /// <summary>
        /// 超上单位 CLASS_HOUR：课时 DAY：天 MONTH：月
        /// </summary>
        [XmlElement("over_unit")]
        public string OverUnit { get; set; }

        /// <summary>
        /// 点名记录id，幂等用
        /// </summary>
        [XmlElement("roll_call_id")]
        public string RollCallId { get; set; }

        /// <summary>
        /// 点名时间
        /// </summary>
        [XmlElement("roll_call_time")]
        public string RollCallTime { get; set; }

        /// <summary>
        /// 课次id
        /// </summary>
        [XmlElement("sched_id")]
        public string SchedId { get; set; }

        /// <summary>
        /// 学员id
        /// </summary>
        [XmlElement("student_id")]
        public string StudentId { get; set; }

        /// <summary>
        /// 上课老师
        /// </summary>
        [XmlElement("teacher_name")]
        public string TeacherName { get; set; }
    }
}
