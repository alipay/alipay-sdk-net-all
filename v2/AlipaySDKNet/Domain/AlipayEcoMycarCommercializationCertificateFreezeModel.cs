using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarCommercializationCertificateFreezeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarCommercializationCertificateFreezeModel : AopObject
    {
        /// <summary>
        /// 蚂蚁门店的唯一标识,如果商品属于本地生活类，必传
        /// </summary>
        [XmlElement("ant_store_id")]
        public string AntStoreId { get; set; }

        /// <summary>
        /// 锁定的凭证列表信息
        /// </summary>
        [XmlArray("certificate_use_info_list")]
        [XmlArrayItem("commercialization_certificate_info")]
        public List<CommercializationCertificateInfo> CertificateUseInfoList { get; set; }

        /// <summary>
        /// 支付宝的用户ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 业务操作流水号 要求唯一
        /// </summary>
        [XmlElement("operate_serial_number")]
        public string OperateSerialNumber { get; set; }

        /// <summary>
        /// 业务的操作时间
        /// </summary>
        [XmlElement("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 业务归属订单号
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
