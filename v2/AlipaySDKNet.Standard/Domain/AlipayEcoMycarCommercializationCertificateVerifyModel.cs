using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarCommercializationCertificateVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarCommercializationCertificateVerifyModel : AopObject
    {
        /// <summary>
        /// 核销凭证的门店ID，如果凭证所属商品类目是本地生活类必传
        /// </summary>
        [XmlElement("ant_store_id")]
        public string AntStoreId { get; set; }

        /// <summary>
        /// 核销的凭证列表信息
        /// </summary>
        [XmlArray("certificate_use_info_list")]
        [XmlArrayItem("commercialization_certificate_info")]
        public List<CommercializationCertificateInfo> CertificateUseInfoList { get; set; }

        /// <summary>
        /// 如果是二阶段核销，该字段为true；默认为false
        /// </summary>
        [XmlElement("has_freeze")]
        public bool HasFreeze { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 核销流水号,要求唯一
        /// </summary>
        [XmlElement("operate_serial_number")]
        public string OperateSerialNumber { get; set; }

        /// <summary>
        /// 实际的核销时间
        /// </summary>
        [XmlElement("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 归属的业务单号，如果是二阶段核销的情况下和锁定的业务履约单号保持一致
        /// </summary>
        [XmlElement("out_biz_order_id")]
        public string OutBizOrderId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
