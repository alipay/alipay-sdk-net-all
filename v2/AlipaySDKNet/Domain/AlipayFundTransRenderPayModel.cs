using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundTransRenderPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransRenderPayModel : AopObject
    {
        /// <summary>
        /// 跟资金订单ID关联的业务场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 链接过期时间,格式为 yyyy-MM-dd HH:mm
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 跳转的编码类型
        /// </summary>
        [XmlElement("initialize_code_type")]
        public string InitializeCodeType { get; set; }

        /// <summary>
        /// 指定的资金订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 跟资金订单ID关联的业务产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 目标端类型
        /// </summary>
        [XmlElement("target_terminal_type")]
        public string TargetTerminalType { get; set; }
    }
}
