using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHealthcaPrescriptionpdfApproveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHealthcaPrescriptionpdfApproveModel : AopObject
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
        /// 姓名样式
        /// </summary>
        [XmlElement("name_style")]
        public string NameStyle { get; set; }

        /// <summary>
        /// 处方单PDF的fileId
        /// </summary>
        [XmlElement("pdf_file_id")]
        public string PdfFileId { get; set; }

        /// <summary>
        /// 药师UID
        /// </summary>
        [XmlElement("pharmacist_code")]
        public string PharmacistCode { get; set; }

        /// <summary>
        /// 请求唯一标识（与后续的结果消费和主动查询对应，需要存储）
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 签名图高度px
        /// </summary>
        [XmlElement("sign_name_height")]
        public long SignNameHeight { get; set; }

        /// <summary>
        /// 签名图宽度px
        /// </summary>
        [XmlElement("sign_name_width")]
        public long SignNameWidth { get; set; }

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
