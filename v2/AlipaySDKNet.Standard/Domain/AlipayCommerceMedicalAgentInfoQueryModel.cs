using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalAgentInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalAgentInfoQueryModel : AopObject
    {
        /// <summary>
        /// 预览时需要传入,用来读取预览配置
        /// </summary>
        [XmlElement("config_order_id")]
        public string ConfigOrderId { get; set; }

        /// <summary>
        /// 由医保自己填的机构唯一标识
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }
    }
}
