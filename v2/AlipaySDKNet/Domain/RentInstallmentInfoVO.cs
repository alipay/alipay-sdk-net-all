using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentInstallmentInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentInstallmentInfoVO : AopObject
    {
        /// <summary>
        /// 当期购买金额。当期购买金=当期购买价-截止到当期已支付租金，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("buyout_price")]
        public string BuyoutPrice { get; set; }

        /// <summary>
        /// 租期。标识第几期
        /// </summary>
        [XmlElement("installment_no")]
        public long InstallmentNo { get; set; }

        /// <summary>
        /// 租金，单位：元,精确到小数点后两位
        /// </summary>
        [XmlElement("installment_price")]
        public string InstallmentPrice { get; set; }

        /// <summary>
        /// 计划扣款时间，表示从该日期起可以发起当前租金扣款
        /// </summary>
        [XmlElement("plan_pay_time")]
        public string PlanPayTime { get; set; }
    }
}
