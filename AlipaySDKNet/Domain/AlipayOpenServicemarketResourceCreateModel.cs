using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketResourceCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketResourceCreateModel : AopObject
    {
        /// <summary>
        /// 资源消耗记录
        /// </summary>
        [XmlArray("ability_resource_consume")]
        [XmlArrayItem("ability_resource_consume")]
        public List<AbilityResourceConsume> AbilityResourceConsume { get; set; }

        /// <summary>
        /// 资源执行的结束时间
        /// </summary>
        [XmlElement("execution_time_end")]
        public string ExecutionTimeEnd { get; set; }

        /// <summary>
        /// 上报的时候计量的开始时间
        /// </summary>
        [XmlElement("execution_time_start")]
        public string ExecutionTimeStart { get; set; }

        /// <summary>
        /// 资源上报接口,订单消息里面的商品code
        /// </summary>
        [XmlElement("outer_code")]
        public string OuterCode { get; set; }

        /// <summary>
        /// isv每次上报的id
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// Frequency：使用次数（次）       Period：使用时长（秒）      Storage：使用存储空间（Byte）      NetworkOut：上行使用流量（Bit/s）      NetworkIn：下行使用流量（Bit/s）       Character：字符数（个）      DailyActiveUser：日活跃用户数（DAU）      PeriodMin：使用时长（分钟）
        /// </summary>
        [XmlElement("record_unit")]
        public string RecordUnit { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
