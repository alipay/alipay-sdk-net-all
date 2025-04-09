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
        /// 代扣出账号，本参数为代扣的支付宝账号对应的支付宝唯一用户号。以2088开头的纯16位数字。
        /// </summary>
        [XmlElement("deduct_out")]
        public string DeductOut { get; set; }

        /// <summary>
        /// 代扣出账号的账户类型,balance为钱包类型
        /// </summary>
        [XmlElement("deduct_out_type")]
        public string DeductOutType { get; set; }

        /// <summary>
        /// 具体是由哪个商家履约的
        /// </summary>
        [XmlElement("mrchant_pid")]
        public string MrchantPid { get; set; }
    }
}
