using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HonorCouponDTO Data Structure.
    /// </summary>
    [Serializable]
    public class HonorCouponDTO : AopObject
    {
        /// <summary>
        /// 优惠券名称
        /// </summary>
        [XmlElement("coupon_name")]
        public string CouponName { get; set; }

        /// <summary>
        /// 优惠券id
        /// </summary>
        [XmlElement("coupon_no")]
        public string CouponNo { get; set; }

        /// <summary>
        /// 优惠券类型，枚举值： 1：放款券；2：还款券
        /// </summary>
        [XmlElement("coupon_type")]
        public long CouponType { get; set; }

        /// <summary>
        /// 券有效期结束时间，时间戳毫秒
        /// </summary>
        [XmlElement("end_time")]
        public long EndTime { get; set; }

        /// <summary>
        /// 领取时间，时间戳毫秒
        /// </summary>
        [XmlElement("receive_time")]
        public long ReceiveTime { get; set; }

        /// <summary>
        /// 券选中状态。0：未选中可选择；1：未选中不可选择；2：选中可取消；3：选中不可取消
        /// </summary>
        [XmlElement("select_status")]
        public long SelectStatus { get; set; }

        /// <summary>
        /// 券有效期开始时间，时间戳毫秒
        /// </summary>
        [XmlElement("start_time")]
        public long StartTime { get; set; }

        /// <summary>
        /// 券状态，枚举值： 1-未使用 2-已使用 3-已过期
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 券不可用原因，不可用时必传，前端根据此字段判断优惠券是否置灰，不可选中
        /// </summary>
        [XmlElement("unusable_reason")]
        public string UnusableReason { get; set; }

        /// <summary>
        /// 使用规则列表，返回List<中文规则描述>
        /// </summary>
        [XmlArray("use_rules")]
        [XmlArrayItem("string")]
        public List<string> UseRules { get; set; }

        /// <summary>
        /// 使用时间，时间戳毫秒，已使用时必传
        /// </summary>
        [XmlElement("used_time")]
        public long UsedTime { get; set; }
    }
}
