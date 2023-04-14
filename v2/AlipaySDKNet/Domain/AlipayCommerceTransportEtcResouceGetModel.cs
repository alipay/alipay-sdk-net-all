using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcResouceGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcResouceGetModel : AopObject
    {
        /// <summary>
        /// 业务标识。  "VIO_IDCARD_FRONT":"车主身份证正面照" "VIO_IDCARD_BACK":"车主身份证反面照" "VI_LICENSE_FRONT":"行驶证正页" "VI_LICENSE_VICE":"行驶证副页" "VI_PHOTO_45":"车头45度照片"
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 支付宝侧订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
