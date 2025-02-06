using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustrySalaryAccountCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustrySalaryAccountCreateModel : AopObject
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// Map<String,String>, JSON BASE64Encode key=AccountAlias, value为账户标识，用于备注 key=Scene, value为场景编号
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 代发商户的商户号
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 合作方系统生成的外部交易流水号，同一交易流水号被视为同一笔交易。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 代发场景和发薪贷场景开子户必填，对应外部对该子户的唯一标识
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 对应的merchantId
        /// </summary>
        [XmlElement("parent_id")]
        public string ParentId { get; set; }

        /// <summary>
        /// 母户类型
        /// </summary>
        [XmlElement("parent_type")]
        public string ParentType { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 开户场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 对接收付通加签的xml，通过base64Encode编码
        /// </summary>
        [XmlElement("sign_xml")]
        public string SignXml { get; set; }
    }
}
