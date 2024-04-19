using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAntlescenterDocusignresultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAntlescenterDocusignresultQueryModel : AopObject
    {
        /// <summary>
        /// 申请方系统标识
        /// </summary>
        [XmlElement("application_system")]
        public string ApplicationSystem { get; set; }

        /// <summary>
        /// 业务线编码
        /// </summary>
        [XmlElement("business_line_code")]
        public string BusinessLineCode { get; set; }

        /// <summary>
        /// 签署中心：签署受理唯一流水号
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 场景编码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 签署任务流水id
        /// </summary>
        [XmlElement("sign_task_id")]
        public string SignTaskId { get; set; }

        /// <summary>
        /// 合同租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
