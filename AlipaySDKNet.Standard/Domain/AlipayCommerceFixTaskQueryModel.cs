using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceFixTaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceFixTaskQueryModel : AopObject
    {
        /// <summary>
        /// 工单唯一id。 获取途径：创建工单的返回结果id，或者通知消息中的工单id进行查询。
        /// </summary>
        [XmlElement("task_id")]
        public long TaskId { get; set; }
    }
}
