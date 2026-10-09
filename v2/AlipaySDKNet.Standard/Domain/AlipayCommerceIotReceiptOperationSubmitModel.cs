using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotReceiptOperationSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotReceiptOperationSubmitModel : AopObject
    {
        /// <summary>
        /// 在op_type为create的时候实体为必传字段
        /// </summary>
        [XmlElement("banner_info")]
        public BannerInfo BannerInfo { get; set; }

        /// <summary>
        /// 操作类型 create  创建 banner offline 下线banner
        /// </summary>
        [XmlElement("op_type")]
        public string OpType { get; set; }

        /// <summary>
        /// 直连商户id
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 间连模式商户id
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
