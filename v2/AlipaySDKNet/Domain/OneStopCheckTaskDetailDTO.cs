using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OneStopCheckTaskDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OneStopCheckTaskDetailDTO : AopObject
    {
        /// <summary>
        /// 应用信息
        /// </summary>
        [XmlElement("app_info")]
        public SlmAppInfo AppInfo { get; set; }

        /// <summary>
        /// slm平台的自动录制的视频
        /// </summary>
        [XmlElement("auto_screen_cap")]
        public string AutoScreenCap { get; set; }

        /// <summary>
        /// 用例名称
        /// </summary>
        [XmlElement("case_ame")]
        public string CaseAme { get; set; }

        /// <summary>
        /// 用例描述
        /// </summary>
        [XmlElement("case_desc")]
        public string CaseDesc { get; set; }

        /// <summary>
        /// 业务的检查点
        /// </summary>
        [XmlArray("check_points")]
        [XmlArrayItem("check_point_v_o")]
        public List<CheckPointVO> CheckPoints { get; set; }

        /// <summary>
        /// 业务自己打印的日志
        /// </summary>
        [XmlElement("custom_log")]
        public string CustomLog { get; set; }

        /// <summary>
        /// slm平台的自定义录制视频
        /// </summary>
        [XmlArray("custom_screen_caps")]
        [XmlArrayItem("slm_artifact_info")]
        public List<SlmArtifactInfo> CustomScreenCaps { get; set; }

        /// <summary>
        /// 用例执行结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 用例错误原因
        /// </summary>
        [XmlElement("error_info")]
        public SlmCaseErrorInfo ErrorInfo { get; set; }

        /// <summary>
        /// slm返回机型
        /// </summary>
        [XmlElement("model")]
        public SlmDeviceInfo Model { get; set; }

        /// <summary>
        /// 用例执行结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 用例截图
        /// </summary>
        [XmlArray("screenshot_list")]
        [XmlArrayItem("slm_artifact_info")]
        public List<SlmArtifactInfo> ScreenshotList { get; set; }

        /// <summary>
        /// 用例执行开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// slm任务ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
