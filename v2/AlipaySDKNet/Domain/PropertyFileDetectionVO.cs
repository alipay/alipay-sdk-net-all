using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PropertyFileDetectionVO Data Structure.
    /// </summary>
    [Serializable]
    public class PropertyFileDetectionVO : AopObject
    {
        /// <summary>
        /// 唯一编码标识
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
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 图片大模型检测结果
        /// </summary>
        [XmlElement("file_ai_check")]
        public bool FileAiCheck { get; set; }

        /// <summary>
        /// 大模型检测原因
        /// </summary>
        [XmlElement("file_ai_check_reason")]
        public string FileAiCheckReason { get; set; }

        /// <summary>
        /// 文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件url
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

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
        /// 图片二维码检测内容
        /// </summary>
        [XmlElement("qrcode_check_reason")]
        public string QrcodeCheckReason { get; set; }

        /// <summary>
        /// 流水号
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }

        /// <summary>
        /// 签到id
        /// </summary>
        [XmlElement("sign_in_id")]
        public string SignInId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
