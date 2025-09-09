using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoTravelPicCreateResponse.
    /// </summary>
    public class AlipayCloudCloudpromoTravelPicCreateResponse : AopResponse
    {
        /// <summary>
        /// 模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 游历分享图片
        /// </summary>
        [XmlElement("travel_pic")]
        public string TravelPic { get; set; }
    }
}
