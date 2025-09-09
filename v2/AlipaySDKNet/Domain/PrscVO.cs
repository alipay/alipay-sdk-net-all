using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrscVO Data Structure.
    /// </summary>
    [Serializable]
    public class PrscVO : AopObject
    {
        /// <summary>
        /// 订单渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 创建处方的时间，即开方时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 用药人性别,1-男 2-女
        /// </summary>
        [XmlElement("gender")]
        public long Gender { get; set; }

        /// <summary>
        /// 用药人年龄,单位  天/月/岁
        /// </summary>
        [XmlElement("patient_age")]
        public string PatientAge { get; set; }

        /// <summary>
        /// 用药人证件号
        /// </summary>
        [XmlElement("patient_id_no")]
        public string PatientIdNo { get; set; }

        /// <summary>
        /// 用药人姓名
        /// </summary>
        [XmlElement("patient_name")]
        public string PatientName { get; set; }

        /// <summary>
        /// 用药人联系号码
        /// </summary>
        [XmlElement("patient_phone_no")]
        public string PatientPhoneNo { get; set; }

        /// <summary>
        /// 处方审核记录
        /// </summary>
        [XmlElement("prescri_review")]
        public PrescReview PrescriReview { get; set; }

        /// <summary>
        /// 处方业务类型 1-互医开方 2-处方外流
        /// </summary>
        [XmlElement("prsc_biz_type")]
        public long PrscBizType { get; set; }

        /// <summary>
        /// 处方编号
        /// </summary>
        [XmlElement("rx_code")]
        public string RxCode { get; set; }

        /// <summary>
        /// 开方医师姓名
        /// </summary>
        [XmlElement("rx_doc_name")]
        public string RxDocName { get; set; }

        /// <summary>
        /// 处方唯一id
        /// </summary>
        [XmlElement("rx_id")]
        public string RxId { get; set; }

        /// <summary>
        /// 处方的pdf访问地址链接
        /// </summary>
        [XmlElement("rx_pdf")]
        public string RxPdf { get; set; }

        /// <summary>
        /// 处方笺图片链接
        /// </summary>
        [XmlElement("rx_picture")]
        public string RxPicture { get; set; }

        /// <summary>
        /// 处方状态
        /// </summary>
        [XmlElement("rx_status")]
        public long RxStatus { get; set; }

        /// <summary>
        /// 商家id
        /// </summary>
        [XmlElement("seller_key")]
        public string SellerKey { get; set; }

        /// <summary>
        /// 门店code
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }

        /// <summary>
        /// 最近一次处方单更新时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }
    }
}
