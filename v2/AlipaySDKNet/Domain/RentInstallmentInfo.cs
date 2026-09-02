using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentInstallmentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentInstallmentInfo : AopObject
    {
        /// <summary>
        /// 残值：指租赁期满后，租赁物的预估剩余价值。平台以这个价格 对买断，赔偿等行为进行巡检。
        /// </summary>
        [XmlElement("buyout_price")]
        public string BuyoutPrice { get; set; }

        /// <summary>
        /// 租期。标识第几期，起始值为1，需保证编号递增
        /// </summary>
        [XmlElement("installment_no")]
        public long InstallmentNo { get; set; }

        /// <summary>
        /// 租金，单位：元,精确到小数点后两位
        /// </summary>
        [XmlElement("installment_price")]
        public string InstallmentPrice { get; set; }

        /// <summary>
        /// 计划扣款时间，表示从该日期起可以发起当前租金扣款，多期需保证付款时间递增。
        /// </summary>
        [XmlElement("plan_pay_time")]
        public string PlanPayTime { get; set; }
    }
}
