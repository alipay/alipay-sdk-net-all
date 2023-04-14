using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdConversionBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdConversionBatchqueryModel : AopObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 转化事件ID列表
        /// </summary>
        [XmlArray("conversion_id_list")]
        [XmlArrayItem("string")]
        public List<string> ConversionIdList { get; set; }

        /// <summary>
        /// 转化事件类型： COLLECT_NORMAL - 免费留资 COLLECT_TRADE - 付费留资 CPA_TMALL_MEMBER_JOIN - 入会 等等
        /// </summary>
        [XmlElement("conversion_type")]
        public string ConversionType { get; set; }

        /// <summary>
        /// 分页参数之页数，从1开始
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页参数之每页大小，最大为1000
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商家在灯火侧的id
        /// </summary>
        [XmlElement("principal_id")]
        public long PrincipalId { get; set; }
    }
}
