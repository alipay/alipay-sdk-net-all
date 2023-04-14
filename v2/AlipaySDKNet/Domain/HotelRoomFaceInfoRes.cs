using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HotelRoomFaceInfoRes Data Structure.
    /// </summary>
    [Serializable]
    public class HotelRoomFaceInfoRes : AopObject
    {
        /// <summary>
        /// 账号类型，默认：anonymous 匿名
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 验证名称
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 验证类型，默认值：PHONE_NO
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 商户id，一般是isv的pid
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 用户手机号信息
        /// </summary>
        [XmlElement("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 外部出入的人脸id
        /// </summary>
        [XmlElement("out_face_id")]
        public string OutFaceId { get; set; }
    }
}
