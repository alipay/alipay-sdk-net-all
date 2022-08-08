using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UniCardFixVoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UniCardFixVoucherInfo : AopObject
    {
        /// <summary>
        /// 券活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 面额，每张代金券可以抵扣的金额。 限制： 币种为人民币，单位为元。小数点以后最多保留两位。 取值范围:0.1<=x<=3000
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 门槛金额。该字段不填写，认为无门槛。 限制： 只有当订单金额大于等于门槛金额时券才能使用。 币种为人民币，单位为元。小数点以后最多保留两位。 设置门槛：取值范围:0.1<=x<= 50000。 如果设置了门槛金额，则必须大于等于0.1，不可以等于0
        /// </summary>
        [XmlElement("floor_amount")]
        public string FloorAmount { get; set; }

        /// <summary>
        /// 用户券id。支付宝为用户优惠券唯一分配的id。
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 券状态： 枚举值: SENDED:可用 USED:已核销(即完全使用), EXPIRED:已过期(只能查询6个月内数据) DELETED:已删除
        /// </summary>
        [XmlElement("voucher_status")]
        public string VoucherStatus { get; set; }
    }
}
