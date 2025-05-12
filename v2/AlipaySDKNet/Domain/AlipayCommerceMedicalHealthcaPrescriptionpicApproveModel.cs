using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHealthcaPrescriptionpicApproveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHealthcaPrescriptionpicApproveModel : AopObject
    {
        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 药师姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 药师UID
        /// </summary>
        [XmlElement("pharmacist_code")]
        public string PharmacistCode { get; set; }

        /// <summary>
        /// 处方单图片的fileId
        /// </summary>
        [XmlElement("pic_file_id")]
        public string PicFileId { get; set; }

        /// <summary>
        /// 图片水印文本
        /// </summary>
        [XmlElement("sign_mark_text")]
        public string SignMarkText { get; set; }

        /// <summary>
        /// 药师签名图片的AFTS的fileId
        /// </summary>
        [XmlElement("sign_name_file_id")]
        public string SignNameFileId { get; set; }

        /// <summary>
        /// 签名图比例(1-100]px
        /// </summary>
        [XmlElement("sign_name_size")]
        public long SignNameSize { get; set; }

        /// <summary>
        /// 签名加签位置X轴px
        /// </summary>
        [XmlElement("sign_name_x")]
        public long SignNameX { get; set; }

        /// <summary>
        /// 签名加签位置Y轴px
        /// </summary>
        [XmlElement("sign_name_y")]
        public long SignNameY { get; set; }
    }
}
