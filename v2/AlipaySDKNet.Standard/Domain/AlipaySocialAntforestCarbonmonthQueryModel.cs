using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialAntforestCarbonmonthQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialAntforestCarbonmonthQueryModel : AopObject
    {
        /// <summary>
        /// 接口文档提供的绿色场景类型
        /// </summary>
        [XmlArray("carbon_type")]
        [XmlArrayItem("string")]
        public List<string> CarbonType { get; set; }

        /// <summary>
        /// 月份（选填）如果为空查询最近12个月的碳账户数据，不为空查询输入日期当前月份数据
        /// </summary>
        [XmlElement("month")]
        public string Month { get; set; }

        /// <summary>
        /// 在对应商户的消费者id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，执行该操作的支付宝用户
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
