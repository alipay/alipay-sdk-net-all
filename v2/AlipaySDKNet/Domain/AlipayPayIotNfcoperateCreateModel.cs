using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayIotNfcoperateCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayIotNfcoperateCreateModel : AopObject
    {
        /// <summary>
        /// 设备id集合
        /// </summary>
        [XmlArray("device_ids")]
        [XmlArrayItem("string")]
        public List<string> DeviceIds { get; set; }

        /// <summary>
        /// 投放活动结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 图片文件地址
        /// </summary>
        [XmlElement("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 货柜对应的商家id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 编辑操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 为活动投放名称
        /// </summary>
        [XmlElement("poster_name")]
        public string PosterName { get; set; }

        /// <summary>
        /// 活动投放开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
