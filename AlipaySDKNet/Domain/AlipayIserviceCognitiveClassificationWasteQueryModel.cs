using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveClassificationWasteQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveClassificationWasteQueryModel : AopObject
    {
        /// <summary>
        /// 业务编码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 图片url，或者文本
        /// </summary>
        [XmlElement("cognition_content")]
        public string CognitionContent { get; set; }

        /// <summary>
        /// 垃圾识别类型
        /// </summary>
        [XmlElement("cognition_type")]
        public string CognitionType { get; set; }

        /// <summary>
        /// 图片组id 适用于垃圾桶等一次投递拍摄多张图片，一次投递一个id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 业务上游流量来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
