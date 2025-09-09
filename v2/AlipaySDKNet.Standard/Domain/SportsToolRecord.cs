using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SportsToolRecord Data Structure.
    /// </summary>
    [Serializable]
    public class SportsToolRecord : AopObject
    {
        /// <summary>
        /// 加速度传感器步频(步/min)
        /// </summary>
        [XmlElement("accel_step_frequency")]
        public string AccelStepFrequency { get; set; }

        /// <summary>
        /// 消耗卡路里（可能为小数）
        /// </summary>
        [XmlElement("calorie")]
        public string Calorie { get; set; }

        /// <summary>
        /// 运动距离，单位米（可能为小数）
        /// </summary>
        [XmlElement("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 运动时长（单位秒），整数
        /// </summary>
        [XmlElement("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// 结束时人脸核验通过
        /// </summary>
        [XmlElement("finish_face_verify_pass")]
        public bool FinishFaceVerifyPass { get; set; }

        /// <summary>
        /// 运动结束时间
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 来源appid
        /// </summary>
        [XmlElement("from_app_id")]
        public string FromAppId { get; set; }

        /// <summary>
        /// 最高海拔，单位米
        /// </summary>
        [XmlElement("max_altitude")]
        public string MaxAltitude { get; set; }

        /// <summary>
        /// 最低海拔，单位米
        /// </summary>
        [XmlElement("min_altitude")]
        public string MinAltitude { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_code")]
        public string OutBizCode { get; set; }

        /// <summary>
        /// 运动计划id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 运动记录时间，用户运动开始时间筛选
        /// </summary>
        [XmlElement("record_date")]
        public string RecordDate { get; set; }

        /// <summary>
        /// 运动记录id
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 中途人脸核验通过
        /// </summary>
        [XmlElement("run_face_verify_pass")]
        public bool RunFaceVerifyPass { get; set; }

        /// <summary>
        /// 速度，统一单位都是(km/h)，（可能为小数）
        /// </summary>
        [XmlElement("speed")]
        public string Speed { get; set; }

        /// <summary>
        /// 运动状态
        /// </summary>
        [XmlElement("sport_status")]
        public string SportStatus { get; set; }

        /// <summary>
        /// 运动类型
        /// </summary>
        [XmlElement("sport_type")]
        public string SportType { get; set; }

        /// <summary>
        /// 开始时人脸校验通过
        /// </summary>
        [XmlElement("start_face_verify_pass")]
        public bool StartFaceVerifyPass { get; set; }

        /// <summary>
        /// 运动开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 本次运动过程中产生的步数数量
        /// </summary>
        [XmlElement("step_count")]
        public string StepCount { get; set; }

        /// <summary>
        /// 平均步频(步/min)
        /// </summary>
        [XmlElement("step_frequency")]
        public string StepFrequency { get; set; }

        /// <summary>
        /// 步数信息是否合法
        /// </summary>
        [XmlElement("step_info_valid")]
        public bool StepInfoValid { get; set; }

        /// <summary>
        /// 平均步幅(米/步)
        /// </summary>
        [XmlElement("step_stride")]
        public string StepStride { get; set; }
    }
}
