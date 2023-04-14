using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerGrowthtaskSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerGrowthtaskSendModel : AopObject
    {
        /// <summary>
        /// 业务时间，标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 业务发生值，用户推进任务
        /// </summary>
        [XmlElement("biz_inc_value")]
        public long BizIncValue { get; set; }

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
        /// 外部业务ID，只会接收处理配置白名单内的数据。
        /// </summary>
        [XmlElement("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// 指定推进的任务记录
        /// </summary>
        [XmlElement("push_record_id")]
        public string PushRecordId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
