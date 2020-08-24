using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DetailBean Data Structure.
    /// </summary>
    [Serializable]
    public class DetailBean : AopObject
    {
        /// <summary>
        /// 自定义附件标识，后续下载附件使用此标识区分。
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 页面展示的附件中文描述（collectAttachement值为true时必填）
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 展示顺序（collectAttachement值为true时必填）
        /// </summary>
        [XmlElement("order")]
        public long Order { get; set; }
    }
}
