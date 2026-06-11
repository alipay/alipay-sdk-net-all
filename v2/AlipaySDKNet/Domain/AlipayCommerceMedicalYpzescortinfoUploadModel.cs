using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalYpzescortinfoUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalYpzescortinfoUploadModel : AopObject
    {
        /// <summary>
        /// 支付宝开放id
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 更新时间，以此确认前后顺序
        /// </summary>
        [XmlElement("biz_timestamp")]
        public string BizTimestamp { get; set; }

        /// <summary>
        /// 陪诊师头像链接
        /// </summary>
        [XmlElement("escort_avatar_url")]
        public string EscortAvatarUrl { get; set; }

        /// <summary>
        /// 陪诊师证件号
        /// </summary>
        [XmlElement("escort_cert_no")]
        public string EscortCertNo { get; set; }

        /// <summary>
        /// 陪诊师证类型
        /// </summary>
        [XmlElement("escort_cert_type")]
        public string EscortCertType { get; set; }

        /// <summary>
        /// 陪诊单id
        /// </summary>
        [XmlElement("escort_id")]
        public string EscortId { get; set; }

        /// <summary>
        /// 陪诊师姓名
        /// </summary>
        [XmlElement("escort_name")]
        public string EscortName { get; set; }

        /// <summary>
        /// 陪诊师电话
        /// </summary>
        [XmlElement("escort_phone")]
        public string EscortPhone { get; set; }

        /// <summary>
        /// 陪诊服务时间，一般指开始的时间或者时间段
        /// </summary>
        [XmlElement("escort_service_time")]
        public string EscortServiceTime { get; set; }

        /// <summary>
        /// 陪诊师标签列表
        /// </summary>
        [XmlElement("escort_tag_list")]
        public string EscortTagList { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单来源
        /// </summary>
        [XmlElement("order_source")]
        public string OrderSource { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 服务商
        /// </summary>
        [XmlElement("service_provider")]
        public string ServiceProvider { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 业务类型（1:预约记录，2:挂号记录）
        /// </summary>
        [XmlElement("table_type")]
        public string TableType { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("uscc")]
        public string Uscc { get; set; }
    }
}
