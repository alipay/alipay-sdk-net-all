using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsRoboOperationSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsRoboOperationSyncModel : AopObject
    {
        /// <summary>
        /// 接口调用方的渠道编码，由支付宝 分配
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("logistics_s_p_i_param_info")]
        public List<LogisticsSPIParamInfo> Data { get; set; }

        /// <summary>
        /// 场景编码
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
