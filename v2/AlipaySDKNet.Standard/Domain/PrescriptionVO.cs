using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrescriptionVO Data Structure.
    /// </summary>
    [Serializable]
    public class PrescriptionVO : AopObject
    {
        /// <summary>
        /// 创建处方的时间，即开方时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 商家侧审核处方的药师姓名
        /// </summary>
        [XmlElement("review_doc_name")]
        public string ReviewDocName { get; set; }

        /// <summary>
        /// 商家侧审核处方驳回的原因
        /// </summary>
        [XmlElement("review_reject_note")]
        public string ReviewRejectNote { get; set; }

        /// <summary>
        /// 商家侧药师审核处方的日期，有年月日，时分秒，精确到秒
        /// </summary>
        [XmlElement("review_time")]
        public string ReviewTime { get; set; }

        /// <summary>
        /// 处方编号
        /// </summary>
        [XmlElement("rx_code")]
        public string RxCode { get; set; }

        /// <summary>
        /// 开具处方的医生姓名
        /// </summary>
        [XmlElement("rx_doc_name")]
        public string RxDocName { get; set; }

        /// <summary>
        /// 处方的pdf访问地址链接
        /// </summary>
        [XmlElement("rx_pdf")]
        public string RxPdf { get; set; }

        /// <summary>
        /// 处方笺的图片访问地址链接
        /// </summary>
        [XmlElement("rx_picture")]
        public string RxPicture { get; set; }

        /// <summary>
        /// 0-待补方,5-待开方,10-已开方,15-待审方,20-已完成,30-已取消
        /// </summary>
        [XmlElement("rx_status")]
        public long RxStatus { get; set; }

        /// <summary>
        /// 最近一次处方单更新时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }
    }
}
