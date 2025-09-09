using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentOrderPriceInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentOrderPriceInfoVO : AopObject
    {
        /// <summary>
        /// 增值服务费，单位：元，精确到小数点后两位。
        /// </summary>
        [XmlElement("additional_price")]
        public string AdditionalPrice { get; set; }

        /// <summary>
        /// 到期购买金额，单位：元,精确到小数点后两位
        /// </summary>
        [XmlElement("buyout_price")]
        public string BuyoutPrice { get; set; }

        /// <summary>
        /// 押金金额，即芝麻免押评估以及预授权冻结的总金额。单位：元，精确到小数点后两位。
        /// </summary>
        [XmlElement("deposit_price")]
        public string DepositPrice { get; set; }

        /// <summary>
        /// 运费，单位：元,精确到小数点后两位
        /// </summary>
        [XmlElement("freight")]
        public string Freight { get; set; }

        /// <summary>
        /// 订单总价，单位：元,精确到小数点后两位
        /// </summary>
        [XmlElement("order_price")]
        public string OrderPrice { get; set; }
    }
}
