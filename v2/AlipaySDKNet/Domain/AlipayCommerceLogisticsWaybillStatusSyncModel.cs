using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsWaybillStatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsWaybillStatusSyncModel : AopObject
    {
        /// <summary>
        /// 接口调用方的渠道编码，由支付宝分配
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 物流运单状态同步的具体内容，根据不同的scene确定参数字段
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("param_info")]
        public List<ParamInfo> Data { get; set; }

        /// <summary>
        /// 物流运单状态同步的场景编码，由支付宝定义
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
