using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsWaybillocrIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsWaybillocrIdentifyModel : AopObject
    {
        /// <summary>
        /// 通知业务标识
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 上传后图片file_id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 物流公司编码
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }
    }
}
