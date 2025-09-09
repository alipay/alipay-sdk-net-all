using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerZmcardProfessionalAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerZmcardProfessionalAddModel : AopObject
    {
        /// <summary>
        /// 证书列表，相同证书每次传入是更新
        /// </summary>
        [XmlArray("certification_list")]
        [XmlArrayItem("zm_card_picture_info")]
        public List<ZmCardPictureInfo> CertificationList { get; set; }

        /// <summary>
        /// 商户请求受理台时传入的外部授权单号，用于验证用户是否授权
        /// </summary>
        [XmlElement("conn_key")]
        public string ConnKey { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 照片列表
        /// </summary>
        [XmlArray("picture_list")]
        [XmlArrayItem("zm_card_picture_info")]
        public List<ZmCardPictureInfo> PictureList { get; set; }

        /// <summary>
        /// 职业人员擅长的领域，如减脂塑形、饮食管理、体能训练、增肌、瑜伽、普拉提、功能性训练、康复训练、体能抗阻、体态调整、理疗、格斗拳击、青少年体适能、其他。
        /// </summary>
        [XmlArray("specialties")]
        [XmlArrayItem("string")]
        public List<string> Specialties { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 大概的从业年限，如1~3年、4~6年、7~10年、10年以上。 不在上述文本中的会被丢弃
        /// </summary>
        [XmlElement("working_years_in_field")]
        public string WorkingYearsInField { get; set; }
    }
}
