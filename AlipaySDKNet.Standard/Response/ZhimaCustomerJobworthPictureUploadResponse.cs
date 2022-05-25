using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerJobworthPictureUploadResponse.
    /// </summary>
    public class ZhimaCustomerJobworthPictureUploadResponse : AopResponse
    {
        /// <summary>
        /// 图片返回ID
        /// </summary>
        [XmlElement("pic_id")]
        public string PicId { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("sub_code")]
        public string SubCode { get; set; }

        /// <summary>
        /// 错误原因
        /// </summary>
        [XmlElement("sub_msg")]
        public string SubMsg { get; set; }
    }
}
