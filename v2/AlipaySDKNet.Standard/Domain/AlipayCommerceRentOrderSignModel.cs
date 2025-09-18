using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentOrderSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentOrderSignModel : AopObject
    {
        /// <summary>
        /// 是否需要人脸核身 true ：（默认）需要人脸核身 false：无需人脸核身
        /// </summary>
        [XmlElement("need_face_validate_flag")]
        public bool NeedFaceValidateFlag { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 租赁订单支付及信用产品签约信息
        /// </summary>
        [XmlElement("rent_sign_info")]
        public RentDoSignInfoDTO RentSignInfo { get; set; }
    }
}
