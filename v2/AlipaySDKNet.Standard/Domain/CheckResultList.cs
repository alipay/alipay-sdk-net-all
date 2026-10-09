using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CheckResultList Data Structure.
    /// </summary>
    [Serializable]
    public class CheckResultList : AopObject
    {
        /// <summary>
        /// 执行动作id，口碑侧提供
        /// </summary>
        [XmlElement("action_id")]
        public string ActionId { get; set; }

        /// <summary>
        /// 枚举类型 RECEIPT: 接单； REJECT: 拒单； RECEIPT_TIMEOUT: 商家超时未接单 POS_ADD_DISH: POS线下加菜 POS_DELETE_DISH: POS线下减菜 POS_PAY: POS线下支付 POS_ADD_DISCOUNT: POS线下添加优惠 POS_SYNC: POS同步订单信息 POS_OPEN: POS开台
        /// </summary>
        [XmlElement("action_name")]
        public string ActionName { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// 校验是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
