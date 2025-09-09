using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserSegmentationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UserSegmentationInfo : AopObject
    {
        /// <summary>
        /// 商户圈选类型
        /// </summary>
        [XmlElement("segmentation_code")]
        public string SegmentationCode { get; set; }

        /// <summary>
        /// 商户圈选分类类型下的具体子类型，由服务商定义。
        /// </summary>
        [XmlElement("sub_segmentation_code")]
        public string SubSegmentationCode { get; set; }
    }
}
