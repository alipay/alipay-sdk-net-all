using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BillNotifyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BillNotifyInfo : AopObject
    {
        /// <summary>
        /// 脱敏地址，按照国网40号文：保留省、市、区县及门牌号最后5位信息
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 账单金额，以元为单位，精确到小数点后2位
        /// </summary>
        [XmlElement("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 账期或者出账时间
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 01:高压 02:低压非居民 03:低压居民
        /// </summary>
        [XmlElement("billkey_type")]
        public string BillkeyType { get; set; }

        /// <summary>
        /// uid和户号通过SM3加密后的后8位
        /// </summary>
        [XmlElement("cipher_billkey")]
        public string CipherBillkey { get; set; }

        /// <summary>
        /// 余额提醒阈值，以元为单位，精确到小数点后2位
        /// </summary>
        [XmlElement("notify_threshold_amount")]
        public string NotifyThresholdAmount { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }
    }
}
