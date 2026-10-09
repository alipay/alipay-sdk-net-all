using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarCommercializationCertificateUnfreezeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarCommercializationCertificateUnfreezeModel : AopObject
    {
        /// <summary>
        /// 履约门店ID，和锁定的履约门店ID保持一致
        /// </summary>
        [XmlElement("ant_store_id")]
        public string AntStoreId { get; set; }

        /// <summary>
        /// 使用的凭证列表信息,和锁定的列表保持一致
        /// </summary>
        [XmlArray("certificate_use_info_list")]
        [XmlArrayItem("commercialization_certificate_info")]
        public List<CommercializationCertificateInfo> CertificateUseInfoList { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 操作流水号，和锁定的操作流水号保持一致
        /// </summary>
        [XmlElement("operate_serial_number")]
        public string OperateSerialNumber { get; set; }

        /// <summary>
        /// 实际释放锁定的时间，要晚于锁定时间
        /// </summary>
        [XmlElement("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
