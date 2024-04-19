using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiCommentDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiCommentDTO : AopObject
    {
        /// <summary>
        /// 定稿意见
        /// </summary>
        [XmlElement("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// 定稿日期
        /// </summary>
        [XmlElement("confirm_date")]
        public string ConfirmDate { get; set; }

        /// <summary>
        /// 定稿类型
        /// </summary>
        [XmlElement("confirm_type")]
        public string ConfirmType { get; set; }

        /// <summary>
        /// 定稿人员
        /// </summary>
        [XmlElement("people")]
        public OpenApiPersonSaDTO People { get; set; }
    }
}
