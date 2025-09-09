using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryMerchantInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryMerchantInfoDTO : AopObject
    {
        /// <summary>
        /// 代扣出账号，如果是余额代扣类型则本参数为代扣的支付宝账号对应的支付宝唯一用户号，以2088开头的纯16位数字。
        /// </summary>
        [XmlElement("deduct_out")]
        public string DeductOut { get; set; }

        /// <summary>
        /// 代扣出账号的账户类型,balance为钱包类型
        /// </summary>
        [XmlElement("deduct_out_type")]
        public string DeductOutType { get; set; }

        /// <summary>
        /// 二级回收商PID信息
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 具体履约商家的PID 当前字段已废弃(更换字段名称，换为merchant_pid)
        /// </summary>
        [XmlElement("mrchant_pid")]
        public string MrchantPid { get; set; }
    }
}
