using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ArInvoiceReturnDetailOrder Data Structure.
    /// </summary>
    [Serializable]
    public class ArInvoiceReturnDetailOrder : AopObject
    {
        /// <summary>
        /// 附件地址 如果是附件类型AttchTypeEnum.HTTP_DOWNLOAD_URL格式为（文件后缀不带.）||下载url 例：下载一个pdf文件 pdf||http://www.xxx.com/download?filename=xxx.pdf&xxx  如果附件类型是发票的oss key直接写osskey即可
        /// </summary>
        [XmlArray("attach_urls")]
        [XmlArrayItem("string")]
        public List<string> AttachUrls { get; set; }

        /// <summary>
        /// 附件类型 INVOICE_OSS_KEY表示上传到发票oss的key HTTP_DOWNLOAD_URL表示附件是一个http get方式的下载链接
        /// </summary>
        [XmlElement("attch_type")]
        public string AttchType { get; set; }

        /// <summary>
        /// 是否通过税务认证,默认为false true:通过,false:不通过
        /// </summary>
        [XmlElement("auth")]
        public bool Auth { get; set; }

        /// <summary>
        /// 发票ID
        /// </summary>
        [XmlElement("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 红冲税务通知单号,认证通过之后必填
        /// </summary>
        [XmlElement("red_notice_no")]
        public string RedNoticeNo { get; set; }
    }
}
