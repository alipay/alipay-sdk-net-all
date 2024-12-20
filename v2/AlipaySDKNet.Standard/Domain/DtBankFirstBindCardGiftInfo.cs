using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DtBankFirstBindCardGiftInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DtBankFirstBindCardGiftInfo : AopObject
    {
        /// <summary>
        /// 是否允许拆分使用 定额红包时： true: 可以拆分使用 false：不可以拆分使用 为null时：历史活动，不可以拆分使用 非立减：空字段
        /// </summary>
        [XmlElement("allow_voucher_split")]
        public bool AllowVoucherSplit { get; set; }

        /// <summary>
        /// bank_code_config_acount_limit值为ASSIGNED_PID_LIST有值，表示银行码指定账号PID列表
        /// </summary>
        [XmlArray("assigned_pid_list")]
        [XmlArrayItem("string")]
        public List<string> AssignedPidList { get; set; }

        /// <summary>
        /// 银行码配置账号限制，bind_source_list包含BANK_QR_CODE时，此参数有值。
        /// </summary>
        [XmlElement("bank_code_config_account_limit")]
        public string BankCodeConfigAccountLimit { get; set; }

        /// <summary>
        /// 绑卡来源
        /// </summary>
        [XmlArray("bind_source_list")]
        [XmlArrayItem("string")]
        public List<string> BindSourceList { get; set; }

        /// <summary>
        /// 红包有效时间
        /// </summary>
        [XmlElement("coupon_available_time")]
        public DtBankCouponAvailableTime CouponAvailableTime { get; set; }

        /// <summary>
        /// 红包使用说明文案
        /// </summary>
        [XmlArray("coupon_instruction_list")]
        [XmlArrayItem("string")]
        public List<string> CouponInstructionList { get; set; }

        /// <summary>
        /// 消费门槛 字段取值： 有门槛，门槛金额XX元  or  零门槛
        /// </summary>
        [XmlElement("threshold_text")]
        public string ThresholdText { get; set; }
    }
}
