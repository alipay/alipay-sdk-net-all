using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentBuyerExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentBuyerExtInfo : AopObject
    {
        /// <summary>
        /// 买家身份证地址
        /// </summary>
        [XmlElement("cert_address")]
        public RentAddress CertAddress { get; set; }

        /// <summary>
        /// 买家身份证反面照片
        /// </summary>
        [XmlElement("cert_back_pic")]
        public RentFile CertBackPic { get; set; }

        /// <summary>
        /// 身份证有效期失效时间
        /// </summary>
        [XmlElement("cert_expire_time")]
        public string CertExpireTime { get; set; }

        /// <summary>
        /// 买家身份证正面照片
        /// </summary>
        [XmlElement("cert_font_pic")]
        public RentFile CertFontPic { get; set; }

        /// <summary>
        /// 买家的身份号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 身份证有效期开始时间
        /// </summary>
        [XmlElement("cert_start_time")]
        public string CertStartTime { get; set; }

        /// <summary>
        /// 买家活体检测照片
        /// </summary>
        [XmlElement("live_pic")]
        public RentFile LivePic { get; set; }

        /// <summary>
        /// 买家的手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 买家的名字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
