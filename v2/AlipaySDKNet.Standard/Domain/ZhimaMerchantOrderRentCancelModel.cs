using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaMerchantOrderRentCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantOrderRentCancelModel : AopObject
    {
        /// <summary>
        /// 信用借还订单号，通过<a href="https://opendocs.alipay.com/apis/api_8/zhima.merchant.order.rent.create">zhima.merchant.order.rent.create</a>(信用借还订单创建(页面))接口创建信用借还订单后获取。
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 信用借还的产品码,固定为：w1010100000000002858。
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
