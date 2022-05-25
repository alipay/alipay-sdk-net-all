using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceOpeneventAppstatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCityserviceOpeneventAppstatusModifyModel : AopObject
    {
        /// <summary>
        /// 光华平台服务入驻接口返回的唯一编码
        /// </summary>
        [XmlElement("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// 状态变更的原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// ONLINE / OFFLINE / MAINTAINING 中选择一个，分别对应 上架 / 下架/ 挂维护
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
