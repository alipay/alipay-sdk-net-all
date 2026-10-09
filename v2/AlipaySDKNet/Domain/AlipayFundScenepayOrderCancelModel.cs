using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundScenepayOrderCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundScenepayOrderCancelModel : AopObject
    {
        /// <summary>
        /// 业务单号由场景支付业务单创建接口获得
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 指定值，由支付宝侧业务提供
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 固定值
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 指定值，由支付宝侧业务提供
        /// </summary>
        [XmlElement("sub_biz_scene")]
        public string SubBizScene { get; set; }
    }
}
