using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QuotaGradientRuleDTO Data Structure.
    /// </summary>
    [Serializable]
    public class QuotaGradientRuleDTO : AopObject
    {
        /// <summary>
        /// 必填，芝麻分350-399范围用户免押限额，单位元。例如设置350-399分用户可免押金5000元，则押金大于5000的商品，450分的用户不支持信用免押，需支付押金。
        /// </summary>
        [XmlElement("score_400")]
        public long Score400 { get; set; }

        /// <summary>
        /// 必填，芝麻分400-449范围用户免押限额，单位元。例如设置400-449分用户可免押金5000元，则押金大于5000的商品，550分的用户不支持信用免押，需支付押金。
        /// </summary>
        [XmlElement("score_450")]
        public long Score450 { get; set; }

        /// <summary>
        /// 必填，芝麻分450-499范围用户免押限额，单位元。例如设置450-499分用户可免押金5000元，则押金大于5000的商品，550分的用户不支持信用免押，需支付押金。
        /// </summary>
        [XmlElement("score_500")]
        public long Score500 { get; set; }

        /// <summary>
        /// 必填，芝麻分500-549范围用户免押限额，单位元。例如设置500-549分用户可免押金5000元，则押金大于5000的商品，550分的用户不支持信用免押，需支付押金。
        /// </summary>
        [XmlElement("score_550")]
        public long Score550 { get; set; }

        /// <summary>
        /// 必填，芝麻分550-599范围用户免押限额，单位元。例如设置550-599分用户可免押金5000元，则押金大于5000的商品，650分的用户不支持信用免押，需支付押金。
        /// </summary>
        [XmlElement("score_600")]
        public long Score600 { get; set; }

        /// <summary>
        /// 必填，芝麻分600-649范围用户免押限额，单位元。例如设置600-649分用户可免押金5000元，则押金大于5000的商品，660分的用户不支持信用免押，需支付押金。
        /// </summary>
        [XmlElement("score_650")]
        public long Score650 { get; set; }

        /// <summary>
        /// 必填，芝麻分650-699范围用户免押限额，单位元。例如设置650-699分用户可免押金5000元，则押金大于5000的商品，550分的用户不支持信用免押，需支付押金。
        /// </summary>
        [XmlElement("score_700")]
        public long Score700 { get; set; }

        /// <summary>
        /// 必填，芝麻分700-749范围用户免押限额，单位元。例如设置700-749分用户可免押金5000元，则押金大于5000的商品，550分的用户不支持信用免押，需支付押金。
        /// </summary>
        [XmlElement("score_750")]
        public long Score750 { get; set; }

        /// <summary>
        /// 必填，芝麻分750-799范围用户免押限额，单位元。例如设置750-799分用户可免押金5000元，则押金大于5000的商品，550分的用户不支持信用免押，需支付押金。
        /// </summary>
        [XmlElement("score_800")]
        public long Score800 { get; set; }

        /// <summary>
        /// 必填，芝麻分800-849范围用户免押限额，单位元。例如设置800-849分用户可免押金5000元，则押金大于5000的商品，550分的用户不支持信用免押，需支付押金。
        /// </summary>
        [XmlElement("score_850")]
        public long Score850 { get; set; }

        /// <summary>
        /// 必填，芝麻分850-899范围用户免押限额，单位元。例如设置850-899分用户可免押金5000元，则押金大于5000的商品，550分的用户不支持信用免押，需支付押金。
        /// </summary>
        [XmlElement("score_900")]
        public long Score900 { get; set; }

        /// <summary>
        /// 必填，芝麻分900-950范围用户免押限额，单位元。例如设置900-950分用户可免押金5000元，则押金大于5000的商品，550分的用户不支持信用免押，需支付押金。
        /// </summary>
        [XmlElement("score_950")]
        public long Score950 { get; set; }
    }
}
