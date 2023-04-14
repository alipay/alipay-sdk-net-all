using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentFixVoucher Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentFixVoucher : AopObject
    {
        /// <summary>
        /// 面额，每张优惠券可以抵扣的金额。  限制： 1、币种为人民币，单位为元。小数点以后最多保留两位。 2、取值范围:0.1<=x<=3000
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 门槛金额。默认无门槛限制。   限制: 1、币种为人民币，单位为元。小数点以后最多保留两位。  2、取值范围:0.1<=x<= 50000。 3、若指定可核销商品编码，门槛金额必填。门槛金额为可核销商品部分的消费金额，而不是订单的消费金额。
        /// </summary>
        [XmlElement("floor_amount")]
        public string FloorAmount { get; set; }
    }
}
