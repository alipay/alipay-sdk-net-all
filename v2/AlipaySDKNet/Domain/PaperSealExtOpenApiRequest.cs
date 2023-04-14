using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaperSealExtOpenApiRequest Data Structure.
    /// </summary>
    [Serializable]
    public class PaperSealExtOpenApiRequest : AopObject
    {
        /// <summary>
        /// 纸质用印上下文
        /// </summary>
        [XmlElement("context")]
        public ContextMap Context { get; set; }

        /// <summary>
        /// 用印份数
        /// </summary>
        [XmlElement("copies_num")]
        public long CopiesNum { get; set; }

        /// <summary>
        /// 延迟交件时间
        /// </summary>
        [XmlElement("delay_days")]
        public string DelayDays { get; set; }

        /// <summary>
        /// 交件方式
        /// </summary>
        [XmlElement("delivery_type")]
        public string DeliveryType { get; set; }

        /// <summary>
        /// 纸质用印展示信息，按照列表顺序在用印审核页面展示
        /// </summary>
        [XmlArray("display_info")]
        [XmlArrayItem("paper_seal_display_open_api_d_t_o")]
        public List<PaperSealDisplayOpenApiDTO> DisplayInfo { get; set; }

        /// <summary>
        /// 期望完成时间
        /// </summary>
        [XmlElement("expect_finish_date")]
        public string ExpectFinishDate { get; set; }

        /// <summary>
        /// 是否仅通知送件人
        /// </summary>
        [XmlElement("only_notify_sender")]
        public bool OnlyNotifySender { get; set; }

        /// <summary>
        /// 保密等级
        /// </summary>
        [XmlElement("private_level")]
        public string PrivateLevel { get; set; }

        /// <summary>
        /// 用印文件类型
        /// </summary>
        [XmlElement("seal_file_type")]
        public string SealFileType { get; set; }

        /// <summary>
        /// 用印送件人信息
        /// </summary>
        [XmlElement("sender")]
        public PeopleOpenApiDTO Sender { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("string")]
        public List<string> Tags { get; set; }
    }
}
