using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WidgetDataAuditPassResult Data Structure.
    /// </summary>
    [Serializable]
    public class WidgetDataAuditPassResult : AopObject
    {
        /// <summary>
        /// 支付宝内部生成的数据唯一标识
        /// </summary>
        [XmlElement("alipay_data_id")]
        public string AlipayDataId { get; set; }

        /// <summary>
        /// 外部数据唯一标识
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }
    }
}
