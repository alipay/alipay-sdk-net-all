using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserDtbankcustActivityorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserDtbankcustActivityorderQueryModel : AopObject
    {
        /// <summary>
        /// 活动流水唯一id，由系统自动生成的，在调用活动触发接口会返回该id。
        /// </summary>
        [XmlElement("activity_order_id")]
        public string ActivityOrderId { get; set; }
    }
}
