using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowPayerwhitelistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsFreightflowPayerwhitelistQueryModel : AopObject
    {
        /// <summary>
        /// 白名单中的单个元素类型不填时，则把owner_account_no下面所有的白名单列表返回，如填写则按照此类型过滤
        /// </summary>
        [XmlElement("allowed_account_type")]
        public string AllowedAccountType { get; set; }

        /// <summary>
        /// 物流公司编码
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 银行管理模式 ANT_MYBANK(网商银行模式); SPDB(浦发银行)
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 归属人唯一标识: 当归属人类型为子户时代表子户卡号
        /// </summary>
        [XmlElement("owner_account_no")]
        public string OwnerAccountNo { get; set; }

        /// <summary>
        /// 归属人类型 SUB_ACCOUNT(子户)
        /// </summary>
        [XmlElement("owner_account_type")]
        public string OwnerAccountType { get; set; }

        /// <summary>
        /// 入金通知
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
