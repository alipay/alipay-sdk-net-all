using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingSharetokenDecodeResponse.
    /// </summary>
    public class AlipayMarketingSharetokenDecodeResponse : AopResponse
    {
        /// <summary>
        /// 第一个按钮名称
        /// </summary>
        [XmlElement("btn_one_name")]
        public string BtnOneName { get; set; }

        /// <summary>
        /// 第一个按钮链接
        /// </summary>
        [XmlElement("btn_one_schema")]
        public string BtnOneSchema { get; set; }

        /// <summary>
        /// 第二个按钮名称
        /// </summary>
        [XmlElement("btn_two_name")]
        public string BtnTwoName { get; set; }

        /// <summary>
        /// 第二个按钮链接
        /// </summary>
        [XmlElement("btn_two_schema")]
        public string BtnTwoSchema { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// icon地址
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
