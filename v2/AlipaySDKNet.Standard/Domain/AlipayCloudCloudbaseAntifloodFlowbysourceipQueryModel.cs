using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseAntifloodFlowbysourceipQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseAntifloodFlowbysourceipQueryModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end")]
        public string End { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start")]
        public string Start { get; set; }

        /// <summary>
        /// 查询TOPN
        /// </summary>
        [XmlElement("topn")]
        public long Topn { get; set; }
    }
}
