using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHealthArchiveSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHealthArchiveSaveModel : AopObject
    {
        /// <summary>
        /// 会话ID
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 档案内容
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 档案ID：报告ID等，从会话来的可存会话ID
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 报告名称、药盒名称
        /// </summary>
        [XmlElement("data_name")]
        public string DataName { get; set; }

        /// <summary>
        /// 数据来源，小程序可填写orgId
        /// </summary>
        [XmlElement("data_source")]
        public string DataSource { get; set; }

        /// <summary>
        /// 健康档案字类型，可以用来划分健康自测量表的二级分类，如心理健康下的焦虑症自测，如果不传无法通过subType检测，
        /// </summary>
        [XmlElement("data_sub_type")]
        public string DataSubType { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("pic_type")]
        public string PicType { get; set; }

        /// <summary>
        /// 图片或PDF链接，完整链接
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 会话的sessionId
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 用户证件编码
        /// </summary>
        [XmlElement("user_card_no")]
        public string UserCardNo { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        [XmlElement("user_cert_type")]
        public string UserCertType { get; set; }

        /// <summary>
        /// 用户的userId，取当前会话的用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
