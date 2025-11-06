using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHealthcaSignqrurlCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHealthcaSignqrurlCreateModel : AopObject
    {
        /// <summary>
        /// 业务标识
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 签署文件ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 签署文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 签署页码
        /// </summary>
        [XmlElement("pos_page")]
        public long PosPage { get; set; }

        /// <summary>
        /// 签署横坐标 像素px
        /// </summary>
        [XmlElement("pos_x")]
        public long PosX { get; set; }

        /// <summary>
        /// 签署纵坐标，像素px
        /// </summary>
        [XmlElement("pos_y")]
        public long PosY { get; set; }

        /// <summary>
        /// 签署完成后的重定向链接，只有签署成功才会跳转
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// 请求唯一标识
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 印章图片高度，像素px
        /// </summary>
        [XmlElement("seal_height")]
        public long SealHeight { get; set; }

        /// <summary>
        /// 印章图片宽度，像素px
        /// </summary>
        [XmlElement("seal_width")]
        public long SealWidth { get; set; }

        /// <summary>
        /// 签署身份证号
        /// </summary>
        [XmlElement("sign_id_card_no")]
        public string SignIdCardNo { get; set; }

        /// <summary>
        /// 签署姓名
        /// </summary>
        [XmlElement("sign_name")]
        public string SignName { get; set; }

        /// <summary>
        /// 签署业务原地址跳转链接，只有签署成功才会跳转
        /// </summary>
        [XmlElement("source_url")]
        public string SourceUrl { get; set; }
    }
}
