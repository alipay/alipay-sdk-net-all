using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityDataQingliangceshiCeshioneQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityDataQingliangceshiCeshioneQueryModel : AopObject
    {
        /// <summary>
        /// 用户测试
        /// </summary>
        [XmlElement("blance_id")]
        public string BlanceId { get; set; }
    }
}
