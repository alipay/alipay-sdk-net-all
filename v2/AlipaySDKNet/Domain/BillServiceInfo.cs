using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BillServiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BillServiceInfo : AopObject
    {
        /// <summary>
        /// 脱敏地址，按照国网40号文：保留省、市、区县及门牌号最后5位信息
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 01:高压 02:低压非居民 03:低压居民
        /// </summary>
        [XmlElement("billkey_type")]
        public string BillkeyType { get; set; }

        /// <summary>
        /// 用户id和户号经过SM3加密后的后8位
        /// </summary>
        [XmlElement("cipher_billkey")]
        public string CipherBillkey { get; set; }

        /// <summary>
        /// 阶梯用电档位
        /// </summary>
        [XmlElement("current_ladder")]
        public string CurrentLadder { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }
    }
}
