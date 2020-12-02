using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveClassificationObjectQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveClassificationObjectQueryModel : AopObject
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
        /// 图片地址
        /// </summary>
        [XmlElement("cognition_content")]
        public string CognitionContent { get; set; }

        /// <summary>
        /// 识别类型
        /// </summary>
        [XmlElement("cognition_type")]
        public string CognitionType { get; set; }

        /// <summary>
        /// 图片组id 适用于一组拍摄多张图片，后续模型训练使用
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
        /// 服务编码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 测试请求，会过滤掉，不会落库并进行数据标注
        /// </summary>
        [XmlElement("test_query")]
        public bool TestQuery { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
