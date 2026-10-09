using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryOfflinelaborRegisterModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryOfflinelaborRegisterModifyModel : AopObject
    {
        /// <summary>
        /// 应聘状态
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 用户入职时间，格式yyyy-mm-dd  hh:mm:ss
        /// </summary>
        [XmlElement("hire_time")]
        public string HireTime { get; set; }

        /// <summary>
        /// 服务商侧该登记记录唯一标识
        /// </summary>
        [XmlElement("out_register_id")]
        public string OutRegisterId { get; set; }
    }
}
