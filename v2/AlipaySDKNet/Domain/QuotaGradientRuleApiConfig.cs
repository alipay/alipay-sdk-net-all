using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QuotaGradientRuleApiConfig Data Structure.
    /// </summary>
    [Serializable]
    public class QuotaGradientRuleApiConfig : AopObject
    {
        /// <summary>
        /// 芝麻分350-399限额，单位元，如果想给不同芝麻分的用户不同的免押金额，比如设置650分用户可免押金5000元，则押金大于5000的商品，650分的用户不支持信用免押，需支付押金。
        /// </summary>
        [XmlElement("score_400")]
        public long Score400 { get; set; }

        /// <summary>
        /// 芝麻分400-449限额，单位元，如果想给不同芝麻分的用户不同的免押金额，比如设置650分用户可免押金5000元，则押金大于5000的商品，650分的用户不支持信用免押，需支付押金。
        /// </summary>
        [XmlElement("score_450")]
        public long Score450 { get; set; }

        /// <summary>
        /// 芝麻分450-499限额，单位元，如果想给不同芝麻分的用户不同的免押金额，比如设置650分用户可免押金5000元，则押金大于5000的商品，650分的用户不支持信用免押，需支付押金。
        /// </summary>
        [XmlElement("score_500")]
        public long Score500 { get; set; }

        /// <summary>
        /// 芝麻分500-549限额，单位元，如果想给不同芝麻分的用户不同的免押金额，比如设置650分用户可免押金5000元，则押金大于5000的商品，650分的用户不支持信用免押，需支付押金。
        /// </summary>
        [XmlElement("score_550")]
        public long Score550 { get; set; }

        /// <summary>
        /// 芝麻分550-599限额，单位元，如果想给不同芝麻分的用户不同的免押金额，比如设置650分用户可免押金5000元，则押金大于5000的商品，650分的用户不支持信用免押，需支付押金。
        /// </summary>
        [XmlElement("score_600")]
        public long Score600 { get; set; }

        /// <summary>
        /// 芝麻分600-649限额，单位元，如果想给不同芝麻分的用户不同的免押金额，比如设置650分用户可免押金5000元，则押金大于5000的商品，650分的用户不支持信用免押，需支付押金。
        /// </summary>
        [XmlElement("score_650")]
        public long Score650 { get; set; }

        /// <summary>
        /// 芝麻分650-699限额，单位元，如果想给不同芝麻分的用户不同的免押金额，比如设置650分用户可免押金5000元，则押金大于5000的商品，650分的用户不支持信用免押，需支付押金。
        /// </summary>
        [XmlElement("score_700")]
        public long Score700 { get; set; }

        /// <summary>
        /// 芝麻分700-749限额，单位元，如果想给不同芝麻分的用户不同的免押金额，比如设置650分用户可免押金5000元，则押金大于5000的商品，650分的用户不支持信用免押，需支付押金。
        /// </summary>
        [XmlElement("score_750")]
        public long Score750 { get; set; }

        /// <summary>
        /// 芝麻分750-799限额，单位元，如果想给不同芝麻分的用户不同的免押金额，比如设置650分用户可免押金5000元，则押金大于5000的商品，650分的用户不支持信用免押，需支付押金。
        /// </summary>
        [XmlElement("score_800")]
        public long Score800 { get; set; }

        /// <summary>
        /// 芝麻分800-849限额，单位元，如果想给不同芝麻分的用户不同的免押金额，比如设置650分用户可免押金5000元，则押金大于5000的商品，650分的用户不支持信用免押，需支付押金。
        /// </summary>
        [XmlElement("score_850")]
        public long Score850 { get; set; }

        /// <summary>
        /// 芝麻分850-899限额，单位元，如果想给不同芝麻分的用户不同的免押金额，比如设置650分用户可免押金5000元，则押金大于5000的商品，650分的用户不支持信用免押，需支付押金。
        /// </summary>
        [XmlElement("score_900")]
        public long Score900 { get; set; }

        /// <summary>
        /// 芝麻分900-950限额，单位元，如果想给不同芝麻分的用户不同的免押金额，比如设置650分用户可免押金5000元，则押金大于5000的商品，650分的用户不支持信用免押，需支付押金。
        /// </summary>
        [XmlElement("score_950")]
        public long Score950 { get; set; }
    }
}
