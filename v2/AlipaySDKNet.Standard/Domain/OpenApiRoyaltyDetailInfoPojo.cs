using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiRoyaltyDetailInfoPojo Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiRoyaltyDetailInfoPojo : AopObject
    {
        /// <summary>
        /// 分账的金额，单位为元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 分账信息中分账百分比。取值范围为大于0，少于或等于100的整数。
        /// </summary>
        [XmlElement("amount_percentage")]
        public long AmountPercentage { get; set; }

        /// <summary>
        /// 分账描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 可选值：达人佣金、平台服务费、技术服务费、其他
        /// </summary>
        [XmlElement("royalty_scene")]
        public string RoyaltyScene { get; set; }

        /// <summary>
        /// 分账类型.
        /// </summary>
        [XmlElement("royalty_type")]
        public string RoyaltyType { get; set; }

        /// <summary>
        /// 收入方账户。如果收入方账户类型为userId，本参数为收入方的支付宝账号对应的支付宝唯一用户号，以2088开头的纯16位数字；如果收入方类型为cardAliasNo，本参数为收入方在支付宝绑定的卡编号；如果收入方类型为loginName，本参数为收入方的支付宝登录号；如果收入方类型为openId，本参数为收入方的支付宝openId信息
        /// </summary>
        [XmlElement("trans_in")]
        public string TransIn { get; set; }

        /// <summary>
        /// 分账收款方姓名，上送则进行姓名与支付宝账号的一致性校验，校验不一致则分账失败。不上送则不进行姓名校验
        /// </summary>
        [XmlElement("trans_in_name")]
        public string TransInName { get; set; }

        /// <summary>
        /// 收入方账户类型。
        /// </summary>
        [XmlElement("trans_in_type")]
        public string TransInType { get; set; }

        /// <summary>
        /// 支出方账户。如果支出方账户类型为userId，本参数为支出方的支付宝账号对应的支付宝唯一用户号，以2088开头的纯16位数字；如果支出方类型为loginName，本参数为支出方的支付宝登录号。 泛金融类商户分账时，该字段不要上送。
        /// </summary>
        [XmlElement("trans_out")]
        public string TransOut { get; set; }

        /// <summary>
        /// 支出方账户类型。
        /// </summary>
        [XmlElement("trans_out_type")]
        public string TransOutType { get; set; }
    }
}
