using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyFiledetectionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyFiledetectionQueryModel : AopObject
    {
        /// <summary>
        /// 编码code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 线圈id
        /// </summary>
        [XmlElement("coil_id")]
        public string CoilId { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [XmlElement("community_id")]
        public string CommunityId { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// ai检测结果
        /// </summary>
        [XmlElement("file_ai_check")]
        public bool FileAiCheck { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 单页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 点位id
        /// </summary>
        [XmlElement("point_id")]
        public string PointId { get; set; }

        /// <summary>
        /// 图片二维码检测结果
        /// </summary>
        [XmlElement("qrcode_check")]
        public bool QrcodeCheck { get; set; }

        /// <summary>
        /// 流水号
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
