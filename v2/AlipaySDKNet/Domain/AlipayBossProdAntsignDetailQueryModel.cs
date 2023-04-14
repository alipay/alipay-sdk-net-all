using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAntsignDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAntsignDetailQueryModel : AopObject
    {
        /// <summary>
        /// 业务方来源
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 业务唯一流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务线
        /// </summary>
        [XmlElement("business_line_code")]
        public string BusinessLineCode { get; set; }

        /// <summary>
        /// 场景值
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 签署流程ID,传值默认查询签署流程下全部任务状态
        /// </summary>
        [XmlElement("sign_flow_id")]
        public string SignFlowId { get; set; }

        /// <summary>
        /// 签署任务id
        /// </summary>
        [XmlElement("sign_task_id")]
        public string SignTaskId { get; set; }

        /// <summary>
        /// 租户信息
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
