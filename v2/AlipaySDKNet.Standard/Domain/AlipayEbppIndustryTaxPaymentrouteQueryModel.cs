using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryTaxPaymentrouteQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryTaxPaymentrouteQueryModel : AopObject
    {
        /// <summary>
        /// v=1 01、02个税 21 社保缴税 31、32、33 非税 41 行邮税  v=2* 03 缴税金4 U1 税费合并 41 行邮税 51、52 社保缴费 61、62 非税
        /// </summary>
        [XmlElement("bt")]
        public string Bt { get; set; }

        /// <summary>
        /// 11:北京市 12:天津市 13:河北省 14:山西省 15:内蒙古自治区 21:辽宁省 22:吉林省 23:黑龙江省 31:上海市 32:江苏省 33:浙江省 34:安徽省 35:福建省 36:江西省 37:山东省 41:河南省 42:湖北省 43:湖南省 44:广东省 45:广西壮族自治区 46:海南省 50:重庆市 51:四川省 52:贵州省 53:云南省 54:西藏自治区 61:陕西省 62:甘肃省 63:青海省 64:宁夏回族自治区 65:新疆维吾尔自治区 91:大连市 92:宁波市 93:厦门市 94:青岛市 95:深圳市 88:其它地区 00:全国
        /// </summary>
        [XmlElement("ck")]
        public string Ck { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 请求来源，由支付宝开发分配提供
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 金额 元
        /// </summary>
        [XmlElement("txn_amt")]
        public string TxnAmt { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 缴税tips版本号 1 2 2.0 2.1 2.2
        /// </summary>
        [XmlElement("v")]
        public string V { get; set; }
    }
}
