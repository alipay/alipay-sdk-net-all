using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAsaingameScheduleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAsaingameScheduleQueryModel : AopObject
    {
        /// <summary>
        /// 查询场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
