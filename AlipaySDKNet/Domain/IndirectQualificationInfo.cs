using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndirectQualificationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndirectQualificationInfo : AopObject
    {
        /// <summary>
        /// 行业经营许可证资质照片，一个行业类目下最多上传6张资质照片（使用图片上传接口）
        /// </summary>
        [XmlArray("image_list")]
        [XmlArrayItem("string")]
        public List<string> ImageList { get; set; }

        /// <summary>
        /// 行业类目编号，支付宝商家行业二级类目code
        /// </summary>
        [XmlElement("mcc_code")]
        public string MccCode { get; set; }
    }
}
