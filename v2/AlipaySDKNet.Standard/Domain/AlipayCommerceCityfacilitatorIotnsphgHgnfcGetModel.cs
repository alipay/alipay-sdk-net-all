using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorIotnsphgHgnfcGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorIotnsphgHgnfcGetModel : AopObject
    {
        /// <summary>
        /// 业务内容
        /// </summary>
        [XmlElement("biz_info")]
        public string BizInfo { get; set; }

        /// <summary>
        /// 设备biztid
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 额外信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 推送产品名称
        /// </summary>
        [XmlElement("push_product_name")]
        public string PushProductName { get; set; }

        /// <summary>
        /// 唯一标识
        /// </summary>
        [XmlElement("req_id")]
        public string ReqId { get; set; }

        /// <summary>
        /// 业务标识处理id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 设备sn
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 上位机biztid
        /// </summary>
        [XmlElement("upper_biz_tid")]
        public string UpperBizTid { get; set; }

        /// <summary>
        /// 上位机sn
        /// </summary>
        [XmlElement("upper_sn")]
        public string UpperSn { get; set; }
    }
}
