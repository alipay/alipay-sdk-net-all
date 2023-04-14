using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerLiferecordSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerLiferecordSendModel : AopObject
    {
        /// <summary>
        /// 业务时间，标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 推进数据
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("push_d_t_o")]
        public List<PushDTO> Data { get; set; }

        /// <summary>
        /// 芝麻内部配置的商户白名单,只有配置过的白名单才允许接入
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 推进任务外部业务号，用于推进某个指定的生活记录任务，通过该id进行关联查询
        /// </summary>
        [XmlElement("push_record_out_biz_no")]
        public string PushRecordOutBizNo { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
