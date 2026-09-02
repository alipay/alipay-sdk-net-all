using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsVoicePlanSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsVoicePlanSaveModel : AopObject
    {
        /// <summary>
        /// 幂等键
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 修改时传入已有计划ID（需OFFLINE状态），不传=新建
        /// </summary>
        [XmlElement("logistics_voice_plan_id")]
        public string LogisticsVoicePlanId { get; set; }

        /// <summary>
        /// 计划名称,允许重复命名
        /// </summary>
        [XmlElement("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 必须与模板scene_type一致
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 通过文件上传接口获得的file_id。文件格式为Csv格式，最大40万条且<5MB
        /// </summary>
        [XmlElement("sn_file_id")]
        public string SnFileId { get; set; }

        /// <summary>
        /// 格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 已审批通过的模板ID
        /// </summary>
        [XmlElement("voice_template_id")]
        public string VoiceTemplateId { get; set; }
    }
}
