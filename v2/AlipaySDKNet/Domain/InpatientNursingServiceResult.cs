using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InpatientNursingServiceResult Data Structure.
    /// </summary>
    [Serializable]
    public class InpatientNursingServiceResult : AopObject
    {
        /// <summary>
        /// 服务小结图片URL
        /// </summary>
        [XmlArray("service_summary_photo_url_list")]
        [XmlArrayItem("string")]
        public List<string> ServiceSummaryPhotoUrlList { get; set; }
    }
}
