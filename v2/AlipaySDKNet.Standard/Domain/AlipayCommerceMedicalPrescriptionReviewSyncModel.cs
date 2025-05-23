using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalPrescriptionReviewSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalPrescriptionReviewSyncModel : AopObject
    {
        /// <summary>
        /// 如果该处方单由合作方自有药师审核，则将合作方的药师编码传入
        /// </summary>
        [XmlElement("out_pharmacist_code")]
        public string OutPharmacistCode { get; set; }

        /// <summary>
        /// 如果该处方单由合作方自有药师审核，则将合作方的药师姓名传入
        /// </summary>
        [XmlElement("out_pharmacist_name")]
        public string OutPharmacistName { get; set; }

        /// <summary>
        /// 平台药师编码，由支付宝购药平台生成，商家通过查询药师的接口可以获取到，在审核处方时，传入该值。
        /// </summary>
        [XmlElement("pharmacist_code")]
        public string PharmacistCode { get; set; }

        /// <summary>
        /// 医院处方编号，该值由医院开方时生成，处方单流转至待审核状态时会将该字段同步给商家，审核时，将该值传入即可。 当前字段已废弃(根据平台处方id流转审核状态即可)
        /// </summary>
        [XmlElement("prescription_code")]
        public string PrescriptionCode { get; set; }

        /// <summary>
        /// 处方ID，由支付宝侧购药平台生成，处方单流转到待审核状态时，会通过【待审方订单推送】接口的prescription_id字段向外部商家同步该处方id，审核时将该值传入即可。
        /// </summary>
        [XmlElement("prescription_id")]
        public string PrescriptionId { get; set; }

        /// <summary>
        /// 驳回理由，若审方驳回，需要填写驳回理由
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// PASSED-药师审核通过，REJECTED-药师审核驳回
        /// </summary>
        [XmlElement("review_result")]
        public string ReviewResult { get; set; }

        /// <summary>
        /// 加签后的处方笺PDF链接
        /// </summary>
        [XmlElement("signed_prsc_pdf_url")]
        public string SignedPrscPdfUrl { get; set; }

        /// <summary>
        /// 如果该处方单由合作方自有药师审核，则将加签后的处方笺图片链接传入
        /// </summary>
        [XmlElement("signed_prsc_pic_url")]
        public string SignedPrscPicUrl { get; set; }

        /// <summary>
        /// 合作方外部门店编码，对应处方购药的门店，由商家生成。
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
