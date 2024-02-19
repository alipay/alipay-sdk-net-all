using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpLabelPlateinfoQueryResponse.
    /// </summary>
    public class ZhimaCreditEpLabelPlateinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 实力标牌高清图片+下载高清图+通过内部单号获取
        /// </summary>
        [XmlElement("hd_pic_src")]
        public string HdPicSrc { get; set; }
    }
}
