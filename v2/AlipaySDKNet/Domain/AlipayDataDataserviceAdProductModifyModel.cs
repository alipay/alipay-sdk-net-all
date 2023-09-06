using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdProductModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdProductModifyModel : AopObject
    {
        /// <summary>
        /// 支付宝唯一id，用于操作鉴权
        /// </summary>
        [XmlElement("alipay_pid")]
        public string AlipayPid { get; set; }

        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 商品实体类型code，由灯火系统分配
        /// </summary>
        [XmlElement("entity_type")]
        public string EntityType { get; set; }

        /// <summary>
        /// 商品外部id
        /// </summary>
        [XmlElement("out_id")]
        public string OutId { get; set; }

        /// <summary>
        /// 商品外部来源code，由灯火系统分配
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 商品外部原始状态
        /// </summary>
        [XmlElement("source_status")]
        public string SourceStatus { get; set; }
    }
}
