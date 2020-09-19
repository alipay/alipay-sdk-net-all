using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAccountClearingcenterPayoffQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountClearingcenterPayoffQueryModel : AopObject
    {
        /// <summary>
        /// 币种 用于查询解付登记薄
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 合作伙伴GKA英文名称 用于查询登记薄信息
        /// </summary>
        [XmlElement("instid")]
        public string Instid { get; set; }

        /// <summary>
        /// 禁用状态 查询被禁用的待解付登记薄 INIT("INIT", "初始"), PAYOFFING("PAYOFFING", "解付中"), PAYOFFED("PAYOFFED", "解付完成"), BACKING("BACKING", "退汇中"), BACKED("BACKED", "退汇完成"), DEPRECAT("DEPRECAT", "弃用")
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
