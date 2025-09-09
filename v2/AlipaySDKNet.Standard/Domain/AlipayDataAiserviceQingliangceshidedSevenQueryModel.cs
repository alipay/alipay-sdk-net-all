using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataAiserviceQingliangceshidedSevenQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceQingliangceshidedSevenQueryModel : AopObject
    {
        /// <summary>
        /// 演示目标
        /// </summary>
        [XmlElement("ceshi_demo")]
        public string CeshiDemo { get; set; }
    }
}
