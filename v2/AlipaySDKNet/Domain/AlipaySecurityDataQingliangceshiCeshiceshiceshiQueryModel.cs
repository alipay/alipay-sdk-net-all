using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityDataQingliangceshiCeshiceshiceshiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityDataQingliangceshiCeshiceshiceshiQueryModel : AopObject
    {
        /// <summary>
        /// 测试目标前端
        /// </summary>
        [XmlElement("blance")]
        public string Blance { get; set; }
    }
}
