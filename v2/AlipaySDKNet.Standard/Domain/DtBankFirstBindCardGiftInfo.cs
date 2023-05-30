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
    }
}
